namespace Secure_pass_storage_system
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Hello_label = new Label();
            logout_btn = new Button();
            userBindingSource = new BindingSource(components);
            txtSite = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnGenerate = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            dgvPasswords = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Site = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            userBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPasswords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // Hello_label
            // 
            Hello_label.AutoSize = true;
            Hello_label.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Hello_label.Location = new Point(599, 32);
            Hello_label.Name = "Hello_label";
            Hello_label.Size = new Size(94, 40);
            Hello_label.TabIndex = 0;
            Hello_label.Text = "label1";
            // 
            // logout_btn
            // 
            logout_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            logout_btn.Location = new Point(1173, 895);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(103, 36);
            logout_btn.TabIndex = 1;
            logout_btn.Text = "Log out";
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += logout_btn_Click;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(User);
            // 
            // txtSite
            // 
            txtSite.Font = new Font("Segoe UI", 14.25F);
            txtSite.Location = new Point(54, 585);
            txtSite.Name = "txtSite";
            txtSite.Size = new Size(270, 33);
            txtSite.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 14.25F);
            txtUsername.Location = new Point(54, 645);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(270, 33);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14.25F);
            txtPassword.Location = new Point(54, 707);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(270, 33);
            txtPassword.TabIndex = 5;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Segoe UI", 14.25F);
            btnGenerate.Location = new Point(349, 707);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(183, 33);
            btnGenerate.TabIndex = 6;
            btnGenerate.Text = "Generate Password";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 14.25F);
            btnSave.Location = new Point(54, 774);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(270, 34);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save password";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 14.25F);
            btnDelete.Location = new Point(54, 834);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(270, 34);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete Password";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvPasswords
            // 
            dgvPasswords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPasswords.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPasswords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPasswords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPasswords.Columns.AddRange(new DataGridViewColumn[] { Id, Site, Username, Password });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPasswords.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPasswords.Location = new Point(54, 207);
            dgvPasswords.Name = "dgvPasswords";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPasswords.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPasswords.Size = new Size(1198, 256);
            dgvPasswords.TabIndex = 10;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Site
            // 
            Site.HeaderText = "Site";
            Site.Name = "Site";
            Site.ReadOnly = true;
            // 
            // Username
            // 
            Username.HeaderText = "Username";
            Username.Name = "Username";
            Username.ReadOnly = true;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.Name = "Password";
            Password.ReadOnly = true;
            // 
            // userBindingSource1
            // 
            userBindingSource1.DataSource = typeof(User);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 943);
            Controls.Add(dgvPasswords);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnGenerate);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtSite);
            Controls.Add(logout_btn);
            Controls.Add(Hello_label);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPasswords).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Hello_label;
        private Button logout_btn;
        private BindingSource userBindingSource;
        private TextBox txtSite;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnGenerate;
        private Button btnSave;
        private Button btnDelete;
        private DataGridView dgvPasswords;
        private BindingSource userBindingSource1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Site;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
    }
}