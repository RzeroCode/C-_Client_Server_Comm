namespace Client_try
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ip_button = new System.Windows.Forms.Button();
            this.send_button = new System.Windows.Forms.Button();
            this.send_textBox = new System.Windows.Forms.TextBox();
            this.port_textBox = new System.Windows.Forms.TextBox();
            this.ip_textBox = new System.Windows.Forms.TextBox();
            this.logs = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Message";
            // 
            // ip_button
            // 
            this.ip_button.Location = new System.Drawing.Point(197, 50);
            this.ip_button.Name = "ip_button";
            this.ip_button.Size = new System.Drawing.Size(75, 23);
            this.ip_button.TabIndex = 3;
            this.ip_button.Text = "Connect";
            this.ip_button.UseVisualStyleBackColor = true;
            this.ip_button.Click += new System.EventHandler(this.ip_button_Click);
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(196, 232);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(75, 23);
            this.send_button.TabIndex = 4;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // send_textBox
            // 
            this.send_textBox.Location = new System.Drawing.Point(80, 232);
            this.send_textBox.Name = "send_textBox";
            this.send_textBox.Size = new System.Drawing.Size(100, 20);
            this.send_textBox.TabIndex = 6;
            this.send_textBox.TextChanged += new System.EventHandler(this.send_textBox_TextChanged);
            // 
            // port_textBox
            // 
            this.port_textBox.Location = new System.Drawing.Point(80, 50);
            this.port_textBox.Name = "port_textBox";
            this.port_textBox.Size = new System.Drawing.Size(100, 20);
            this.port_textBox.TabIndex = 7;
            // 
            // ip_textBox
            // 
            this.ip_textBox.Location = new System.Drawing.Point(80, 15);
            this.ip_textBox.Name = "ip_textBox";
            this.ip_textBox.Size = new System.Drawing.Size(100, 20);
            this.ip_textBox.TabIndex = 8;
            // 
            // logs
            // 
            this.logs.Location = new System.Drawing.Point(15, 105);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(227, 96);
            this.logs.TabIndex = 9;
            this.logs.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.ip_textBox);
            this.Controls.Add(this.port_textBox);
            this.Controls.Add(this.send_textBox);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.ip_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ip_button;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.TextBox send_textBox;
        private System.Windows.Forms.TextBox port_textBox;
        private System.Windows.Forms.TextBox ip_textBox;
        private System.Windows.Forms.RichTextBox logs;
    }
}

