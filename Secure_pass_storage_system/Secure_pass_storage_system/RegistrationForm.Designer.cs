namespace Secure_pass_storage_system
{
    partial class RegistrationForm
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
            Reg_button = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // Reg_button
            // 
            Reg_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Reg_button.Location = new Point(100, 259);
            Reg_button.Name = "Reg_button";
            Reg_button.Size = new Size(127, 35);
            Reg_button.TabIndex = 6;
            Reg_button.Text = "Sign up";
            Reg_button.UseVisualStyleBackColor = true;
            Reg_button.Click += Reg_button_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 141);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(300, 23);
            textBox2.TabIndex = 5;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(12, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 29);
            textBox1.TabIndex = 4;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 209);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(300, 23);
            textBox3.TabIndex = 7;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(100, 44);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 8;
            label1.Text = "Enter username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(100, 117);
            label2.Name = "label2";
            label2.Size = new Size(117, 21);
            label2.TabIndex = 9;
            label2.Text = "Enter password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(76, 185);
            label3.Name = "label3";
            label3.Size = new Size(174, 21);
            label3.TabIndex = 10;
            label3.Text = "Confirm your password";
            // 
            // button1
            // 
            button1.Image = Properties.Resources.open1;
            button1.Location = new Point(318, 131);
            button1.Name = "button1";
            button1.Size = new Size(51, 33);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.open1;
            button2.Location = new Point(318, 199);
            button2.Name = "button2";
            button2.Size = new Size(51, 33);
            button2.TabIndex = 12;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 316);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(Reg_button);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "RegistrationForm";
            Text = "RegistationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Reg_button;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}