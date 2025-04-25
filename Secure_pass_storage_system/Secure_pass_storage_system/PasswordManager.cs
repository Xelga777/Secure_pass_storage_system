using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;

public class PasswordManager
{
    private string _connectionString;

    public PasswordManager(string connectionString)
    {
        _connectionString = connectionString;
    }

    // Генерация сложного пароля
    public static string GeneratePassword(int length = 12)
    {
        const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+-=<>?";

        StringBuilder password = new StringBuilder();
        using (var rng = new RNGCryptoServiceProvider())
        {
            byte[] randomBytes = new byte[length];
            rng.GetBytes(randomBytes);

            for (int i = 0; i < randomBytes.Length; i++)
            {
                password.Append(validChars[randomBytes[i] % validChars.Length]);
            }
        }

        return password.ToString();
    }

    // Шифрование пароля (AES)
    private static string EncryptPassword(string plainText, string key)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Encoding.UTF8.GetBytes(key.PadRight(32)); // Ключ должен быть 32 байта
            aesAlg.IV = new byte[16]; // Нулевой IV (можно улучшить)

            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
            byte[] encryptedBytes = encryptor.TransformFinalBlock(Encoding.UTF8.GetBytes(plainText), 0, plainText.Length);

            return Convert.ToBase64String(encryptedBytes);
        }
    }

    // Дешифрование пароля (AES)
    private static string DecryptPassword(string cipherText, string key)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Encoding.UTF8.GetBytes(key.PadRight(32));
            aesAlg.IV = new byte[16];

            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            byte[] decryptedBytes = decryptor.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);

            return Encoding.UTF8.GetString(decryptedBytes);
        }
    }

    // Добавление пароля в базу данных
    public bool SavePassword(int userId, string site, string username, string password, string masterKey)
    {
        string encryptedPassword = EncryptPassword(password, masterKey);

        using (var connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            string query = "INSERT INTO Passwords (UserId, Site, Username, Password) VALUES (@UserId, @Site, @Username, @Password)";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@UserId", userId);
            cmd.Parameters.AddWithValue("@Site", site);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", encryptedPassword);

            return cmd.ExecuteNonQuery() > 0;
        }
    }

    // Получение всех паролей пользователя
    public List<(string Id, string Site, string Username, string Password)> GetPasswords(int userId, string masterKey)
    {
        List<(string, string, string, string)> passwords = new List<(string, string, string, string)>();

        using (var connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            string query = "SELECT Id, Site, Username, Password FROM Passwords WHERE UserId = @UserId";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@UserId", userId);

            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader["Id"].ToString();
                string site = reader["Site"].ToString();
                string username = reader["Username"].ToString();
                string encryptedPassword = reader["Password"].ToString();
                string decryptedPassword = DecryptPassword(encryptedPassword, masterKey);

                passwords.Add((id, site, username, decryptedPassword));
            }
        }

        return passwords;
    }

    // Удаление пароля
    public bool DeletePassword(int userId, string site)
    {
        using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            string query = "DELETE FROM Passwords WHERE UserId = @UserId AND Site = @Site";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@UserId", userId);
            cmd.Parameters.AddWithValue("@Site", site);

            return cmd.ExecuteNonQuery() > 0;
        }
    }
}