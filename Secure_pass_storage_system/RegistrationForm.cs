using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secure_pass_storage_system
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void Reg_button_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string confirmPassword = textBox3.Text;

            // Проверка пароля на соответствие требованиям безопасности
            if (!IsPasswordValid(password))
            {
                MessageBox.Show("Пароль не соответствует требованиям безопасности. Убедитесь, что он содержит:\n" +
                                "- минимум 8 символов\n" +
                                "- хотя бы одну заглавную букву\n" +
                                "- хотя бы одно число\n" +
                                "- хотя бы один специальный символ");
                return;
            }

            if (password == confirmPassword)
            {
                // Добавляем нового пользователя в базу данных
                int flag = DatabaseHelper.AddUser(username, password);
                if (flag == 0)
                {
                    MessageBox.Show("Регистрация прошла успешно! Теперь вы можете войти в систему.");
                }
                else
                {
                    MessageBox.Show("Пользователь с таким именем уже существует. Попробуйте другое имя пользователя.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.Close();  // Закрываем форму регистрации
            }
            else
            {
                MessageBox.Show("Пароли не совпадают. Попробуйте снова.");
            }
        }

        // Метод для проверки пароля
        private bool IsPasswordValid(string password)
        {
            // Пароль должен содержать минимум 8 символов
            if (password.Length < 8)
            {
                return false;
            }

            // Регулярное выражение для проверки наличия хотя бы одной заглавной буквы, числа и специального символа
            string pattern = @"^(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$";
            var regex = new System.Text.RegularExpressions.Regex(pattern);
            return regex.IsMatch(password);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0';  // Показываем символы пароля
                button1.Image = Properties.Resources.open1;
            }
            else
            {
                textBox2.PasswordChar = '*';  // Скрываем символы пароля
                button1.Image = Properties.Resources.close1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.PasswordChar == '*')
            {
                textBox3.PasswordChar = '\0';  // Показываем символы пароля
                button2.Image = Properties.Resources.open1;
            }
            else
            {
                textBox3.PasswordChar = '*';  // Скрываем символы пароля
                button2.Image = Properties.Resources.close1;
            }
        }
    }
}
