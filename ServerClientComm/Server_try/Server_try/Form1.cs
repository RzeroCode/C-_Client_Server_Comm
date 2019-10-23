using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_try
{
    public partial class Form1 : Form
    {
        Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        List<Socket> clientSockets = new List<Socket>();

        bool terminating = false;
        bool listening = false;
        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            InitializeComponent();
        }
        private void Port_Button_Click(object sender, EventArgs e)
        {
            int serverPort;
            if (Int32.TryParse(Port_textBox.Text, out serverPort))
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, serverPort);
                serverSocket.Bind(endPoint);
                serverSocket.Listen(3);

                Message_button.Enabled = true;
                Message_textBox.Enabled = true;
                Port_Button.Enabled = false;
                listening = true;

                Thread acceptThread = new Thread(Accept);
                acceptThread.Start();
                Logs_richTextBox.AppendText("Listening to the port:" + serverPort + ".\n");
            }
            else
            {
                Logs_richTextBox.AppendText("Couldn't connect to the port.\n");
            }
        }
        private void Accept()
        {
            while (listening)
            {
                try
                {
                    Socket clientSocket = serverSocket.Accept();
                    clientSockets.Add(clientSocket);
                    Logs_richTextBox.AppendText("A client has connected.\n");

                    Thread recieveThread = new Thread(Recieve);
                    recieveThread.Start();
                }
                catch
                {
                    if (terminating)
                    {
                        listening = false;
                    }
                    else
                    {
                        Logs_richTextBox.AppendText("The socket stopped working.\n");
                    }
                }
            }
        }
        private void Recieve()
        {
            Socket thisClient = clientSockets[clientSockets.Count() - 1];
            bool connected = true;
            while (connected && !terminating)
            {
                try
                {
                    Byte[] buffer = new Byte[64];
                    thisClient.Receive(buffer);

                    string incomingMessage = Encoding.Default.GetString(buffer);
                    incomingMessage = incomingMessage.Substring(0, incomingMessage.IndexOf("\0"));
                    Logs_richTextBox.AppendText("Client: " + incomingMessage + "\n");
                }
                catch
                {
                    if (!terminating)
                        Logs_richTextBox.AppendText("Client has disconnected.\n");
                    thisClient.Close();
                    clientSockets.Remove(thisClient);
                    connected = false;
                }
            }
        }
        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            listening = false;
            terminating = true;
            Environment.Exit(0);
        }
        private void Message_button_Click(object sender, EventArgs e)
        {
            string message = Message_textBox.Text;
            if (message != "" && message.Length <= 64)
            {
                Byte[] buffer = Encoding.Default.GetBytes(message);
                foreach (Socket client in clientSockets)
                {
                    try
                    {
                        client.Send(buffer);
                    }
                    catch
                    {
                        Logs_richTextBox.AppendText("Couldn't send the message.\n");
                        terminating = true;
                        Message_textBox.Enabled = false;
                        Message_button.Enabled = false;
                        Port_textBox.Enabled = true;
                        Port_Button.Enabled = true;
                        serverSocket.Close();
                    }
                }
            }
        }
        private void Port_label_Click(object sender, EventArgs e)
        {

        }

        private void Port_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Message_textBox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
