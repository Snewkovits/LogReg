using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogReg_Console.Utils
{
    internal class Menu
    {
        public string[] MenuItems { get; set; }
        public string Caption { get; set; }
        public char SelectedChar { get; set; }
        public ConsoleKey ExitKey { private get; set; }
        public ConsoleColor SelectedColor = ConsoleColor.Magenta;
        int Index = 0;
        public Menu(string[] items = null, string caption = null, char selectedChar = '>')
        {
            MenuItems = items;
            Caption = caption;
            SelectedChar = selectedChar;
        }

        public int Create()
        {
            ConsoleKeyInfo key;
            int topStart = 0;
            int prevIndex;

            if (MenuItems == null) return -1;
            Console.CursorVisible = false;

            Console.SetCursorPosition(0, 0);
            if (Caption != null) 
            {
                Console.Write($"\t{Caption}");
                topStart = 2;
            }
            else topStart = 0;

            Console.SetCursorPosition(0, topStart);

            for (int i = 0; i < MenuItems.Length; i++)
            {
                if (Index == i)
                {
                    Console.ForegroundColor = SelectedColor;
                    Console.WriteLine($"{SelectedChar} {MenuItems[i]}");
                }
                else Console.WriteLine($"  {MenuItems[i]}");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            do
            {
                key = Console.ReadKey(true);
                prevIndex = Index;
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (Index > 0)
                            Index--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (Index < MenuItems.Length - 1)
                            Index++;
                        break;
                    default: break;
                }
                UpdateLine(Index);
                UpdateLine(prevIndex);
            }
            while (key.Key != ConsoleKey.Enter);
            Console.CursorVisible = true;
            return Index;
        }

        void UpdateLine(int line)
        {
            int topStart = 0;
            if (Caption != null) topStart = 2;
            Console.SetCursorPosition(0, topStart + line);
            if (line == Index)
            {
                Console.ForegroundColor = SelectedColor;
                Console.Write($"{SelectedChar} {MenuItems[line]}");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
                Console.Write($"  {MenuItems[line]}");
        }
    }
}
