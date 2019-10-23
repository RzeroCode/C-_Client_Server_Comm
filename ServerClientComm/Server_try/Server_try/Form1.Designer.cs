namespace Server_try
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
            this.Port_label = new System.Windows.Forms.Label();
            this.Port_textBox = new System.Windows.Forms.TextBox();
            this.Port_Button = new System.Windows.Forms.Button();
            this.Logs_richTextBox = new System.Windows.Forms.RichTextBox();
            this.Message_textBox = new System.Windows.Forms.TextBox();
            this.Message_button = new System.Windows.Forms.Button();
            this.Message_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Port_label
            // 
            this.Port_label.AutoSize = true;
            this.Port_label.Location = new System.Drawing.Point(12, 9);
            this.Port_label.Name = "Port_label";
            this.Port_label.Size = new System.Drawing.Size(26, 13);
            this.Port_label.TabIndex = 0;
            this.Port_label.Text = "Port";
            this.Port_label.Click += new System.EventHandler(this.Port_label_Click);
            // 
            // Port_textBox
            // 
            this.Port_textBox.Location = new System.Drawing.Point(79, 9);
            this.Port_textBox.Name = "Port_textBox";
            this.Port_textBox.Size = new System.Drawing.Size(100, 20);
            this.Port_textBox.TabIndex = 1;
            this.Port_textBox.TextChanged += new System.EventHandler(this.Port_textBox_TextChanged);
            // 
            // Port_Button
            // 
            this.Port_Button.Location = new System.Drawing.Point(197, 9);
            this.Port_Button.Name = "Port_Button";
            this.Port_Button.Size = new System.Drawing.Size(75, 23);
            this.Port_Button.TabIndex = 2;
            this.Port_Button.Text = "Enter";
            this.Port_Button.UseVisualStyleBackColor = true;
            this.Port_Button.Click += new System.EventHandler(this.Port_Button_Click);
            // 
            // Logs_richTextBox
            // 
            this.Logs_richTextBox.Location = new System.Drawing.Point(15, 66);
            this.Logs_richTextBox.Name = "Logs_richTextBox";
            this.Logs_richTextBox.Size = new System.Drawing.Size(185, 96);
            this.Logs_richTextBox.TabIndex = 3;
            this.Logs_richTextBox.Text = "";
            // 
            // Message_textBox
            // 
            this.Message_textBox.Location = new System.Drawing.Point(79, 203);
            this.Message_textBox.Name = "Message_textBox";
            this.Message_textBox.Size = new System.Drawing.Size(100, 20);
            this.Message_textBox.TabIndex = 4;
            this.Message_textBox.TextChanged += new System.EventHandler(this.Message_textBox_TextChanged);
            // 
            // Message_button
            // 
            this.Message_button.Location = new System.Drawing.Point(197, 203);
            this.Message_button.Name = "Message_button";
            this.Message_button.Size = new System.Drawing.Size(75, 23);
            this.Message_button.TabIndex = 5;
            this.Message_button.Text = "Send";
            this.Message_button.UseVisualStyleBackColor = true;
            this.Message_button.Click += new System.EventHandler(this.Message_button_Click);
            // 
            // Message_label
            // 
            this.Message_label.AutoSize = true;
            this.Message_label.Location = new System.Drawing.Point(12, 210);
            this.Message_label.Name = "Message_label";
            this.Message_label.Size = new System.Drawing.Size(50, 13);
            this.Message_label.TabIndex = 6;
            this.Message_label.Text = "Message";
            this.Message_label.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Message_label);
            this.Controls.Add(this.Message_button);
            this.Controls.Add(this.Message_textBox);
            this.Controls.Add(this.Logs_richTextBox);
            this.Controls.Add(this.Port_Button);
            this.Controls.Add(this.Port_textBox);
            this.Controls.Add(this.Port_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Port_label;
        private System.Windows.Forms.TextBox Port_textBox;
        private System.Windows.Forms.Button Port_Button;
        private System.Windows.Forms.RichTextBox Logs_richTextBox;
        private System.Windows.Forms.TextBox Message_textBox;
        private System.Windows.Forms.Button Message_button;
        private System.Windows.Forms.Label Message_label;
    }
}

