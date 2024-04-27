using LogReg_Console.UserUtils;
using LogReg_Console.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogReg_Console.UserUtils
{
    static class UserExtensions
    {
        public static UserLoginStatus Login(this User user)
        {
            Instance instance = new Instance();
            Dictionary<int, dynamic[]> data = instance.RunCommand($"SELECT username, passwd FROM userdata WHERE username = '{user.Username}'");
            if (data.Count < 1)
                return UserLoginStatus.NotAvailable;
            if (data[0][1] != user.Password) return UserLoginStatus.WrongPassword;
            return UserLoginStatus.LoggedIn;
        }

        public static UserRegisterStatus Register(this User user, string password)
        {
            if (user.Email.Contains('@') && user.Email.Contains('.'))
            {
                if (user.Email.Split('@')[0].Length < 4 || user.Email.Split('@')[1].Length < 4)
                    if (user.Email.Split('@')[1].Split('.')[0].Length < 4 || user.Email.Split('.')[1].Length < 3)
                        return UserRegisterStatus.FalseEmail;
            }
            else if (!user.Email.Contains('@') || !user.Email.Contains('.'))
                return UserRegisterStatus.FalseEmail;

            if (user.Password != password.Trim())
                return UserRegisterStatus.PasswordNotSame;

            Instance instance = new Instance();
            Dictionary<int, dynamic[]> data = instance.RunCommand($"SELECT username FROM userdata WHERE username = '{user.Username}'");
            if (data.Count > 0) return UserRegisterStatus.UserExists;
            instance.RunCommand($"INSERT INTO userdata (username, email, passwd) VALUES ('{user.Username}','{user.Email}','{user.Password}')");
            return UserRegisterStatus.Registered;
        }
    }
}
