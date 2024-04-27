using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogReg_Console.Utils
{
    internal class Input
    {
        public static ConsoleKey ExitKey;

        public static string ReadLine(bool isPassword = false)
        {
            string result = string.Empty;
            ConsoleKeyInfo pressed;

            do
            {
                pressed = Console.ReadKey(true);
                switch (pressed.Key)
                {
                    case ConsoleKey.Enter: continue;
                    case ConsoleKey.Tab: continue;
                    case ConsoleKey.Backspace:
                        if (result.Length > 0)
                        {
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            Console.Write(' ');
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            if (result.Length > 1)
                                result = result.Substring(0, result.Length - 1);
                            else result = "";
                        }
                        break;
                    default:
                        if (isPassword)
                            Console.Write('*');
                        else
                            Console.Write(pressed.KeyChar);
                        result += pressed.KeyChar;
                        break;
                }
            }
            while (pressed.Key != ConsoleKey.Enter && pressed.Key != ConsoleKey.Tab);
            Console.Write('\n');
            return result;
        }

        public static string ReadLineForm(string result, bool isPassword = false)
        {
            ConsoleKeyInfo pressed;
            do
            {
                pressed = Console.ReadKey(true);
                switch (pressed.Key)
                {
                    case ConsoleKey.Enter: continue;
                    case ConsoleKey.Tab: continue;
                    case ConsoleKey.Backspace:
                        if (result.Length > 0)
                        {
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            Console.Write(' ');
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            if (result.Length > 1)
                                result = result.Substring(0, result.Length - 1);
                            else result = "";
                        }
                        else
                        {
                            pressed = new ConsoleKeyInfo(' ', ConsoleKey.Enter, false, false, false);
                            return "EXITTEDKKI";
                        }
                        break;
                    default:
                        if (pressed.Key == ExitKey)
                        {
                            return "EXITFORM";
                        }
                        if (isPassword)
                            Console.Write('*');
                        else
                            Console.Write(pressed.KeyChar);
                        result += pressed.KeyChar;
                        break;
                }
            }
            while (pressed.Key != ConsoleKey.Enter && pressed.Key != ConsoleKey.Tab);
            Console.Write('\n');
            return result;
        }
    }
}
