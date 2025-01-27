using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSessiorDi
{
    public class GameManager
    {
        private Iplayer _player1;
        private Iplayer _player2;
        public GameManager(Iplayer player1,Iplayer player2) {
            _player1 = player1;
            _player2 = player2;
        
        }
        public Result Play()
        {
            Choice p1 = _player1.GetChoice();
            Choice p2 = _player2.GetChoice();
            
            if (p1 == p2) { return Result.Draw; }
            if (p1 == Choice.Rock && p2 == Choice.Sessior
                || p1 == Choice.Sessior && p2 == Choice.Papper
                || p1 == Choice.Papper && p2 == Choice.Rock)
            {
                return Result.Player1win;
            };
            return Result.Player2win;


        }
        

    }
    public enum Choice
    {
        Rock,
        Papper,
        Sessior
    }
    public enum Result
    {
        Player1win,
        Player2win,
        Draw
    }
}