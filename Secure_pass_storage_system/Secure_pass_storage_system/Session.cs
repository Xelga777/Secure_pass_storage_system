namespace Secure_pass_storage_system
{
    public static class Session
    {
        public static int UserId { get; set; }  // ID пользователя из базы
        public static string Username { get; set; } // Имя пользователя
        public static string MasterKey { get; set; } // Пароль 
    }
}