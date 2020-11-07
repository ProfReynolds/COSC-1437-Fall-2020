using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBrain;

/*
* Professor Reynolds
*/

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Mark Reynolds");
            Console.WriteLine("TicTacxToe Console Test");

            var ticTacToeGame = new TicTacToeGame();

            var testcase = ticTacToeGame.IdentifyMarker(0, 0);
            Console.WriteLine();
            Console.WriteLine("after instantiating the TicTacToeGame class,");
            Console.WriteLine($"cell 0,0 is currently : {testcase}");
            Console.WriteLine($"note: testcase is of type : {testcase.GetType()}");

            ticTacToeGame.ResetGrid();

            // now that the class is reset and ready to play, what are the markers?
            var testcase2 = ticTacToeGame.IdentifyMarker(0, 0);
            Console.WriteLine();
            Console.WriteLine("now that the class is reset and ready to play,");
            Console.WriteLine($"cell 0,0 is now : {testcase2}");

            // set a marker to human. does it stick?
            ticTacToeGame.PlaceMarker(0, 0, CellOwners.Human);
            var testcase3 = ticTacToeGame.IdentifyMarker(0, 0);
            Console.WriteLine();
            Console.WriteLine("the marker is set to human, checking,");
            Console.WriteLine($"cell 0,0 is finally : {testcase3}");

            // set the player name to YOUR name
            ticTacToeGame.PlayerName = "Prof Reynolds";
            Console.WriteLine();
            Console.WriteLine("the player name is set and is now");
            Console.WriteLine($"PlayerName : {ticTacToeGame.PlayerName}");

            // checking the rest of the methods that actually return a value
            Console.WriteLine();
            Console.WriteLine($"Winner : {ticTacToeGame.Winner}");
            Console.WriteLine($"EvaluateBoard : {ticTacToeGame.EvaluateBoard()}");
            Console.WriteLine($"IdentifyWinner : {ticTacToeGame.IdentifyWinner()}");

            Console.WriteLine();
            Console.Write("Press any key to continue");
            Console.ReadKey();
        }
    }
}
