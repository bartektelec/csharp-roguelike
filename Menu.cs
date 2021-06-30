using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_roguelike
{
    class Menu
    {
        public static void Run()
        {

            var IsRunning = false;
            var MenuPointerPosition = 0;
            var MenuOptions = new string[] { "Start game", "Options", "Quit game" };

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Rogue-like game");
                for (int i = 0; i < MenuOptions.Length; i++)
                {
                    Console.WriteLine();
                    if (MenuPointerPosition == i)
                    {
                        Console.Write("> ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                    Console.Write(MenuOptions[i]);
                }
                var button = Console.ReadKey();
                switch (button.Key)
                {
                    case System.ConsoleKey.Enter:
                        Show(MenuOptions[MenuPointerPosition]);
                        IsRunning = true;
                        break;
                    case System.ConsoleKey.UpArrow:
                        MenuPointerPosition--;
                        if (MenuPointerPosition < 0)
                        {
                            MenuPointerPosition = MenuOptions.Length - 1;
                        }
                        break;
                    case System.ConsoleKey.DownArrow:
                        MenuPointerPosition++;
                        if (MenuPointerPosition > MenuOptions.Length - 1)
                        {
                            MenuPointerPosition = 0;
                        }
                        break;
                }
            } while (!IsRunning);
        }

        static void Show(string title)
        {
            Console.Clear();
            Console.WriteLine(title);
        }
    }

}

