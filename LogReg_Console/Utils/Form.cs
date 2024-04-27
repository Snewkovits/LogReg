using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LogReg_Console.Utils
{
    internal class Form
    {
        public Dictionary<string, bool> MenuItems { get; set; }
        public string Caption { get; set; }
        public Form(Dictionary<string, bool> items = null, string caption = null) 
        {
            MenuItems = items;
            Caption = caption;
        }

        public Dictionary<string, string> Create()
        {
            Dictionary<string, string> results = new Dictionary<string, string>();
            int topStart = 0;

            Console.Clear();

            Console.SetCursorPosition(0, 0);
            if (Caption != null)
            {
                Console.Write($"\t{Caption}");
                topStart = 2;
            }
            else topStart = 0;

            Console.SetCursorPosition(0, topStart);

            for (int i = 0; i < MenuItems.Count; i++)
            {
                Console.WriteLine($"{Capitalize(MenuItems.ElementAt(i).Key)}:");
                results.Add(MenuItems.ElementAt(i).Key, string.Empty);
            }

            for (int i = 0; i < MenuItems.Count; i++)
            {
                Console.SetCursorPosition(MenuItems.ElementAt(i).Key.ToString().Length + results.ElementAt(i).Value.Length + 2, topStart + i);
                results[MenuItems.ElementAt(i).Key] = Input.ReadLineForm(results.ElementAt(i).Value, MenuItems.ElementAt(i).Value);

                if (results.ElementAt(i).Value == "EXITFORM")
                {
                    return new Dictionary<string, string> { { "RESULT", "NULL" } };
                }

                if (results.ElementAt(i).Value == "EXITTEDKKI")
                {
                    if (results.ElementAt(i).Key == results.ElementAt(0).Key)
                    {
                        results[results.ElementAt(i).Key] = string.Empty;
                        i = -1;
                    }
                    else
                    {
                        results[results.ElementAt(i).Key] = string.Empty;
                        i -= 2;
                    }
                }

            }
            return results;
        }

        string Capitalize(string data)
        {
            return $"{data.Substring(0, 1).ToUpper()}{data.Substring(1, data.Length - 1)}";
        }
    }
}
