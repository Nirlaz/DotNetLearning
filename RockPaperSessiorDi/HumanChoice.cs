using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSessiorDi
{
    internal class HumanChoice : Iplayer
    {
        public Choice GetChoice()
        {
            Choice p1;
            do
            {
                Console.WriteLine("Enter Rock Paper Sessior:");
                String input = Console.ReadLine().ToUpper();
                if (input == "R")
                {
                    p1 = Choice.Rock;
                    break;
                }
                else if (input == "S")
                {
                    p1 = Choice.Sessior;
                    break;
                }
                else if (input == "P")
                {
                    p1 = Choice.Papper;
                    break;
                }
                else
                {
                    Console.WriteLine("Try Again");
                }
            } while (true);
            Console.WriteLine($"Player One Choice = {p1}");
            return p1;
        }
    }
}
