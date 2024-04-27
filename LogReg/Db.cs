using System.Collections.Generic;
using MySqlConnector;

namespace LogReg
{
    class Db
    {
        public MySqlConnection Connect { get => new MySqlConnection(new MySqlConnectionStringBuilder() 
        {
            Server = "localhost",
            Port = 3306,
            UserID = "root",
            Password = "",
            Database = "userloginapp"
        }.ConnectionString); }

        public MySqlConnection connection = null;
        public Db() { connection = Connect; }

        public List<User> GetAllUser()
        {
            List<User> users = new List<User>();
            MySqlConnection conn = Connect;
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT userid, username, email FROM userdata;";
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                users.Add(new User() { id = reader.GetInt32("userid"), username = reader.GetString("username"), email = reader.GetString("email"), password = "N/A" });
            }
            return users;
        }

        public UserStatus UsersExists(string username, string password)
        {
            User user = new User() { id = 0, username = "", password = "", email = "" };
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT username, passwd FROM userdata WHERE username = @username";
            cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
            connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                user.username = reader.GetString("username");
                user.password = reader.GetString("passwd");
            }
            connection.Close();

            if (user.username == null || user.username == "")
                return UserStatus.UNE;
            if (user.password != password)
                return UserStatus.WP;
            else return UserStatus.UE;
        }

        public bool CreateUser(string username, string email, string password)
        {
            if (!email.Contains("@") || !email.Contains("."))
                return false;
            User user = new User() { id = 0, username = username, email = email, password = password };
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO userdata (username, email, passwd) VALUES (@username, @email, @password);";
            cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = user.username;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = user.email;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = user.password;
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            return true;
        }

        public enum UserStatus
        {
            UNE,
            WP,
            UE
        }
    }
}
