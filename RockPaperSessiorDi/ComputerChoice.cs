using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSessiorDi
{
    public class ComputerChoice : Iplayer
    {
        Random _random = new Random();
        public Choice GetChoice()

        {
            Choice p2 = (Choice)_random.Next(0, 3);
            Console.WriteLine($"Player Two Choice = {p2}");
            return p2;
        }
    }
}
