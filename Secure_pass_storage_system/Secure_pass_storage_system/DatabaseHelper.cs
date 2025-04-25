using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace Secure_pass_storage_system
{
    internal class DatabaseHelper
    {
        public const string ConnectionString = "Data Source=user_data.db;Version=3;";

        // Создание базы данных и таблицы, если она не существует
        public static void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string createTableQuery = @"
                        CREATE TABLE IF NOT EXISTS Users (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Username TEXT NOT NULL,
                            PasswordHash TEXT NOT NULL
                        );
                    ";
                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void InitializePassTable()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string checkTableQuery = @"
                        CREATE TABLE IF NOT EXISTS Passwords (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Site Text NOT NULL,
                            Username TEXT NOT NULL,
                            Password TEXT NOT NULL,
                            UserId INTEGER NOT NULL,
                            FOREIGN KEY (UserId) REFERENCES Users(Id) ON DELETE CASCADE
                        );
                    ";

                using (var command = new SQLiteCommand(checkTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }


        // Метод для добавления нового пользователя
        public static int AddUser(string username, string password)
        {
            if (UserExists(username))
            {
                return 1;
            }

            string hashedPassword = User.HashPassword(password);

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO Users (Username, PasswordHash) VALUES (@Username, @PasswordHash)";
                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                    //command.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                    command.ExecuteNonQuery();
                }
            }
            return 0;
        }

        public static string GetPassHash(string username)
        {
            if (UserExists(username))
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT PasswordHash FROM Users WHERE Username = @Username";
                    var command = new SQLiteCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetString(0);
                        }
                    }
                }
            }
            return null;
        }

        public static int GetUserId(string username)
        {
            if (UserExists(username))
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT Id FROM Users WHERE Username = @Username";
                    var command = new SQLiteCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetInt32(0);
                        }
                    }
                }
            }
            return -1;
        }

        // Метод для проверки пароля пользователя
        public static bool VerifyUser(string username, string password)
        {
            string hashedPassword = User.HashPassword(password);
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string selectQuery = "SELECT PasswordHash FROM Users WHERE Username = @Username";
                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHash = reader.GetString(0);
                            return storedHash == hashedPassword;
                        }
                    }
                }
            }
            return false;
        }

        // Метод для проверки существования пользователя
        public static bool UserExists(string username)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string selectQuery = "SELECT 1 FROM Users WHERE Username = @Username";
                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    using (var reader = command.ExecuteReader())
                    {
                        return reader.Read();
                    }
                }
            }
        }
    }
}
