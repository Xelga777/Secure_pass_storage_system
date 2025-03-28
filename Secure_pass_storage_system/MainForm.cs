using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Secure_pass_storage_system
{
    public partial class MainForm : Form
    {
        private PasswordManager _passwordManager;

        public MainForm()
        {
            InitializeComponent();
            _passwordManager = new PasswordManager("Data Source=user_data.db;Version=3;");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Hello_label.Text = "Hello, " + Session.Username + "!";
            DatabaseHelper.InitializePassTable();
            LoadPasswords();
        }

        // Загрузка паролей из базы
        private void LoadPasswords()
        {
            // Очистка DataGridView перед загрузкой новых данных
            dgvPasswords.Rows.Clear();

            // Получаем список паролей из базы
            var passwords = _passwordManager.GetPasswords(Session.UserId, Session.MasterKey);

            // Перебираем все полученные записи и добавляем их в DataGridView
            foreach (var entry in passwords)
            {
                dgvPasswords.Rows.Add(entry.Id, entry.Site, entry.Username, entry.Password);
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Session.UserId = 0;
            Session.Username = string.Empty;
            Session.MasterKey = string.Empty;
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string site = txtSite.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(site) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = _passwordManager.SavePassword(Session.UserId, site, username, password, Session.MasterKey);
            if (success)
            {
                MessageBox.Show("Пароль сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPasswords();
            }
            else
            {
                MessageBox.Show("Ошибка при сохранении пароля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtPassword.Text = PasswordManager.GeneratePassword();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPasswords.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите пароль для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string site = dgvPasswords.SelectedRows[0].Cells[1].Value.ToString();
            DialogResult dlgRes = MessageBox.Show("Подтвердите удаление пароля для сервиса " + site, "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgRes == DialogResult.Yes)
            {
                bool success = _passwordManager.DeletePassword(Session.UserId, site);

                if (success)
                {
                    MessageBox.Show("Пароль удален!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPasswords();
                }
                else
                {
                    MessageBox.Show("Ошибка при удалении пароля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
    