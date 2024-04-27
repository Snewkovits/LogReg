using LogReg_Console.UserUtils;
using LogReg_Console.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogReg_Console
{
    internal class Program
    {
        static void Main()
        {
            Console.Title = "LogReg";
            Input.ExitKey = ConsoleKey.Escape;
            int result = 0;
            bool skip = false;
            Menu menu = new Menu()
            {
                Caption = "LogReg_Console (Kilépés a form-ból: 'ESC')",
                MenuItems = new string[] { "Bejelentkezés", "Regisztráció", "Kilépés" }
            };
            while (result != 2)
            {
                Console.Clear();
                if (!skip)
                    result = menu.Create();
                switch (result)
                {
                    case 0:
                        Console.Clear();
                        Form login = new Form()
                        {
                            Caption = "Bejelentkezés",
                            MenuItems = new Dictionary<string, bool>()
                           {
                               { "felhasználónév", false },
                               { "jelszó", true }
                           }
                        };
                        Dictionary<string, string> loginDatas = login.Create();
                        if (loginDatas.ElementAt(0).Value == "NULL" && loginDatas.ElementAt(0).Key == "RESULT")
                            break;
                        switch (new User()
                        {
                            Id = 0,
                            Email = string.Empty,
                            Username = loginDatas["felhasználónév"],
                            Password = loginDatas["jelszó"]
                        }.Login())
                        {
                            case UserLoginStatus.LoggedIn:
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("Sikeresen bejelentkeztél!");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                break;
                            case UserLoginStatus.WrongPassword:
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("A jelszó nem egyezik!");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                break;
                            case UserLoginStatus.NotAvailable:
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("Nem létezik ilyen felhasználó!");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                break;
                        }
                        Console.ReadKey(true);
                        break;
                    case 1:
                        Console.Clear();
                        skip = false;
                        Form register = new Form()
                        {
                            Caption = "Regisztrálás",
                            MenuItems = new Dictionary<string, bool>()
                           {
                               { "felhasználónév", false },
                               { "email", false },
                               { "jelszó", true },
                               { "jelszó újra", true }
                           }
                        };
                        Dictionary<string, string> registerDatas = register.Create();
                        if (registerDatas.ElementAt(0).Value == "NULL" && registerDatas.ElementAt(0).Key == "RESULT")
                            break;
                        switch (new User()
                        {
                            Id = 0,
                            Email = registerDatas["email"],
                            Username = registerDatas["felhasználónév"],
                            Password = registerDatas["jelszó"]
                        }.Register(registerDatas["jelszó újra"]))
                        {
                            case UserRegisterStatus.Registered:
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("Sikeres regisztrálás!");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                break;
                            case UserRegisterStatus.PasswordNotSame:
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("A jelszó nem egyezik!");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                skip = true;
                                break;
                            case UserRegisterStatus.UserExists:
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("Már létezik ilyen felhasználó!");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                skip = true;
                                break;
                            case UserRegisterStatus.FalseEmail:
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("Az email nincs megfelelő formátumban!");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                skip = true;
                                break;
                        }
                        Console.ReadKey(true);
                        break;
                }
            }
        }
    }
}
