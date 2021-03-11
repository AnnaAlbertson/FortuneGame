using Game_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class GameUI
    {
        Repository _repo = new Repository();
        public void Run()
        {
            Console.Title= "Fortune Game";
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Menu();
        }
        private void Menu()
        {

            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Fortune Game.\n" +
                    "Let's start by picking a color.\n" +
                    "1) Magenta\n" +
                    "2) Green\n" +
                    "3) Purple\n" +
                    "4) Cyan\n" +
                    "5) Exit");


                string inputColor = Console.ReadLine();

                switch (inputColor)
                {
                    //Magenta
                    case "1":
                        Console.WriteLine("Pick a number: \n" +
                            "1\n" +
                            "2\n" +
                            "5\n" +
                            "6");
                        int inputNum1 = Convert.ToInt32(Console.ReadLine());
                        if (inputNum1 == 1)
                        {
                            _repo.Fortune1();
                        }
                        else if (inputNum1 == 2)
                        {
                            _repo.Fortune2();
                        }
                        else if (inputNum1 == 5)
                        {
                            _repo.Fortune5();
                        }
                        else if (inputNum1 == 6)
                        {
                            _repo.Fortune6();
                        }
                        else
                        {
                            Console.WriteLine("Please enter 1, 2, 5, or 6");
                        }
                    break;
                    //Green
                    case "2":
                        Console.WriteLine("Pick a number: \n" +
                            "3\n" +
                            "4\n" +
                            "7\n" +
                            "8");
                        int inputNum2 = Convert.ToInt32(Console.ReadLine());
                        if (inputNum2 == 3)
                        {
                            _repo.Fortune3();
                        }
                        else if (inputNum2 == 4)
                        {
                            _repo.Fortune4();
                        }
                        else if (inputNum2 == 7)
                        {
                            _repo.Fortune7();
                        }
                        else if (inputNum2 == 8)
                        {
                            _repo.Fortune8();
                        }
                        else
                        {
                            Console.WriteLine("Please enter 3, 4, 7, or 8");
                        }
                        break;
                    //Purple
                    case "3":
                        Console.WriteLine("Pick a number: \n" +
                            "1\n" +
                            "2\n" +
                            "5\n" +
                            "6");
                        int inputNum3 = Convert.ToInt32(Console.ReadLine());
                        if (inputNum3 == 1)
                        {
                            _repo.Fortune1();
                        }
                        else if (inputNum3 == 2)
                        {
                            _repo.Fortune2();
                        }
                        else if (inputNum3 == 5)
                        {
                            _repo.Fortune5();

                        }
                        else if (inputNum3 == 6)
                        {
                            _repo.Fortune6();
                        }
                        else
                        {
                            Console.WriteLine("Please enter 1, 2, 5, or 6");
                        }
                        break;
                    //Cyan
                    case "4":
                    Console.WriteLine("Pick a number: \n" +
                            "3\n" +
                            "4\n" +
                            "7\n" +
                            "8");
                        int inputNum4 = Convert.ToInt32(Console.ReadLine());
                        if (inputNum4 == 3)
                        {
                            _repo.Fortune3();
                        }
                        else if (inputNum4 == 4)
                        {
                            _repo.Fortune4();
                        }
                        else if (inputNum4 == 7)
                        {
                            _repo.Fortune7();
                        }
                        else if (inputNum4 == 8)
                        {
                            _repo.Fortune8();
                        }
                        else
                        {
                            Console.WriteLine("Please enter 3, 4, 7, 8");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;
                }
                Console.WriteLine("Please press any key to continue");
                Console.ReadKey();
                Console.Clear();
            } 
        }
    }
}
