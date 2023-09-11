using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = true;
            while (exit)
            {
                Console.Write("Choose an option:\n0.Rock\n1.Paper\n2.Scissors\nYour choice: ");
                int plChoice, pcChoice;
                plChoice = int.Parse(Console.ReadLine());
                pcChoice = new Random().Next(0, 3);
                switch (pcChoice)
                {
                    case 0:
                        Console.WriteLine("Random choosed Rock.");
                        Console.WriteLine((plChoice == 0) ? ("It's a tie.") : (plChoice == 2) ? ("You lost.") : ("You won."));
                        break;
                    case 1:
                        Console.WriteLine("Random choosed Paper.");
                        Console.WriteLine((plChoice == 1) ? ("It's a tie.") : (plChoice == 0) ? ("You lost.") : ("You won."));
                        break;
                    case 2:
                        Console.WriteLine("Random choosed Scissors.");
                        Console.WriteLine((plChoice == 2) ? ("It's a tie.") : (plChoice == 1) ? ("You lost.") : ("You won."));
                        break;
                }
                Console.WriteLine("Do you want to play again?");
                Console.WriteLine("1.Yes\n2.No");
                int final;
                final = int.Parse(Console.ReadLine());
                exit = (final == 1) ? true : false;
            }
            Console.ReadKey();
        }
    }
}
