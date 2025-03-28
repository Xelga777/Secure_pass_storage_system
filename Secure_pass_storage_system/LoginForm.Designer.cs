namespace Secure_pass_storage_system
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Auth_button = new Button();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(555, 30);
            label1.TabIndex = 0;
            label1.Text = "Welcome to the secure password storage system model";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(127, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 29);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(127, 122);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(300, 29);
            textBox2.TabIndex = 2;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // Auth_button
            // 
            Auth_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Auth_button.Location = new Point(220, 170);
            Auth_button.Name = "Auth_button";
            Auth_button.Size = new Size(127, 31);
            Auth_button.TabIndex = 3;
            Auth_button.Text = "Sign in";
            Auth_button.UseVisualStyleBackColor = true;
            Auth_button.Click += Auth_button_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(153, 221);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(242, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Don't have an account? Click here to sign up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(465, 280);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 5;
            label2.Text = "Made by XelgaCh";
            // 
            // button1
            // 
            button1.Image = Properties.Resources.open1;
            button1.Location = new Point(433, 123);
            button1.Name = "button1";
            button1.Size = new Size(51, 29);
            button1.TabIndex = 12;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(577, 304);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(Auth_button);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Secure password storage system model";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button Auth_button;
        private LinkLabel linkLabel1;
        private Label label2;
        private Button button1;
    }
}
