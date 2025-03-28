using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace Secure_pass_storage_system
{
    // TODO: Перенести всю работу с БД в database helper
    public class User
    {
        public int Id { get; set; }           // Идентификатор пользователя (может быть автоинкрементом в базе данных)
        public string Username { get; set; }  // Имя пользователя
        public string PasswordHash { get; set; } // Хеш пароля
        public DateTime CreatedAt { get; set; } // Дата создания пользователя

        private string _connectionString;    // Строка подключения к базе данных

        public User(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Метод для проверки данных пользователя (например, при авторизации)
        public static bool Authenticate(string username, string password)
        {
            string storedHash = DatabaseHelper.GetPassHash(username);
            string hashPass = HashPassword(password);
            if (DatabaseHelper.UserExists(username) && VerifyPassword(password, storedHash))
            {
                Session.UserId = DatabaseHelper.GetUserId(username);
                Session.Username = username;
                Session.MasterKey = password;
                return true;
            }

            return false;
        }

        // Метод для хеширования пароля (добавим простой пример)
        public static string HashPassword(string password)
        {
            // Здесь можно использовать более сложную систему хеширования, например, SHA-256 с солью
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        // Метод для проверки пароля
        public static bool VerifyPassword(string password, string storedHash)
        {
            // Проверка пароля
            string passwordHash = HashPassword(password);
            return passwordHash == storedHash;
        }


        // Метод для получения пользователя из базы данных по имени пользователя
        public User GetUserByUsername(string username)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Users WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new User(_connectionString)
                    {
                        Id = (int)reader["Id"],
                        Username = reader["Username"].ToString(),
                        PasswordHash = reader["PasswordHash"].ToString(),
                        CreatedAt = (DateTime)reader["CreatedAt"]
                    };
                }

                return null;
            }
        }
    }

}
