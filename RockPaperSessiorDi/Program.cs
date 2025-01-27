using RockPaperSessiorDi;

GameManager gm = new GameManager(new HumanChoice(),new HumanChoice());
do
{
    Result _result = gm.Play();
    if(_result == Result.Player1win)
    {
        Console.WriteLine("Player1 Win");

    }else if(_result == Result.Player2win)
    {
        Console.WriteLine("Player2 win");
    }
    else if(_result == Result.Draw)
    {
        Console.WriteLine("Draw");
    }
    Console.WriteLine("Do you want to Contine Y/N? ");
} while (Console.ReadLine().ToUpper() == "Y");