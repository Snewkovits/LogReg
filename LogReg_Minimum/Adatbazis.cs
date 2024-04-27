using System;
using System.Collections.Generic;
using MySqlConnector;

namespace LogReg_Minimum
{
    internal class Adatbazis
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        public Adatbazis()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.Database = "userloginapp";
            builder.UserID = "root";
            builder.Password = "";
            conn = new MySqlConnection(builder.ConnectionString);
        }

        public List<User> GetAllUser()
        {
            List<User> users = new List<User>();
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM userdata";
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                User user = new User(
                    reader.GetInt32("userid"), 
                    reader.GetString("username"), 
                    reader.GetString("email"), 
                    reader.GetString("passwd"));
                users.Add(user);
            }
            conn.Close();
            return users;
        }

        public void AddUser(User ujUser)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = $"INSERT INTO userdata (username, email, passwd) VALUES ('{ujUser.getUsername()}', '{ujUser.getEmail()}', '{ujUser.getPassword()}')";
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
