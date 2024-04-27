using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Xml.Schema;
using LogReg_Console.UserUtils;
using Microsoft.SqlServer.Server;
using MySqlConnector;

namespace LogReg_Console.Utils
{    
    internal class Instance
    {
        public MySqlConnection Connection { get; private set; }
        public MySqlCommand Set
        {
            get
            {
                Connection = new MySqlConnection(new MySqlConnectionStringBuilder()
                {
                    Server = "localhost",
                    Port = 3306,
                    Database = "userloginapp",
                    UserID = "root",
                    Password = ""
                }.ConnectionString);
                Connection.Open();
                return Connection.CreateCommand();
            }
            private set { Set = value; }
        }
        void Close()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
                Connection.Close();
        }
        public Dictionary<int, dynamic[]> RunCommand(string command = null)
        {
            Dictionary<int, dynamic[]> datas = new Dictionary<int, dynamic[]>();
            int index = 0;

            if (command == null)
                return null;
            MySqlCommand cmd = Set;
            cmd.CommandText = command;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dynamic[] fields = new dynamic[reader.FieldCount];
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    int ifnum = 0;
                    fields[i] = reader.GetString(i);
                    if (int.TryParse(fields[i], out ifnum))
                        fields[i] = ifnum;
                }
                datas.Add(index, fields);
                index++;
            }
            Close();
            return datas;
        }
    }
}
