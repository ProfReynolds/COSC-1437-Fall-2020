using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using TheBrain;
using NUnit.Framework;
using Shouldly;

/*
 * ProfReynolds
 *
 * Do not use this class in any earlier assignment. Do not copy 
 * parts of this work into earlier assignments. The unit tests 
 * provided here are different than the earlier assignments.
 */

namespace TheBrain_Tests
{
    [TestFixture()]
    public class TheBrainTestMethods
    {
        [Test]
        public void TestClassInstantiation()
        {
            // acting that the class will instantiate

            // arrange

            // act
            var ticTacToeGame = new TicTacToeGame();

            // assert
            ticTacToeGame.ShouldNotBeNull(); // class sucessfully instantiated
            ticTacToeGame.PlayerName.ShouldBe("Human"); // player name property propery initialized
            // ticTacToeGame.EvaluateBoard().ShouldBeFalse(); // this test WILL crash because _winningCombinations not initialized
            ticTacToeGame.Winner.ShouldBe(CellOwners.Error); // winner property is not initialized (defaults to Error)
            ticTacToeGame.IdentifyMarker(0, 0).ShouldBe(CellOwners.Error); // should initially return Error
            ticTacToeGame.IdentifyWinner().ShouldBe("Error"); // should initially return Error
        }

        [Test]
        public void PlayerNameTest()
        {
            // Player name property is a holding bin. This is the only testable anything prior to ResetGrid

            // arrange
            var ticTacToeGame = new TicTacToeGame();

            // act
            ticTacToeGame.PlayerName = "Prof Reynolds";

            // assert
            ticTacToeGame.PlayerName.ShouldBe("Prof Reynolds");
        }

        [Test]
        public void ResetGridTest()
        {
            // ResetGrid is necessary and must preceed everything except PlayerName
            var ticTacToeGame = new TicTacToeGame();

            // arrange

            // act
            ticTacToeGame.ResetGrid();

            // assert
            ticTacToeGame.ShouldNotBeNull(); // class sucessfully instantiated
            ticTacToeGame.PlayerName.ShouldBe("Human"); // player name property propery initialized
            ticTacToeGame.EvaluateBoard().ShouldBeFalse(); // no winner yet
            ticTacToeGame.Winner.ShouldBe(CellOwners.Open); // winner property should now be Open
            ticTacToeGame.IdentifyMarker(0, 0).ShouldBe(CellOwners.Open); // _ticTacToeCells should now be initialized to open
            ticTacToeGame.IdentifyWinner().ShouldBeEmpty(); // there is no winner
        }

        [Test]
        public void PlaceMarkerTest()
        {
            // make sure that a cell can be assigned as either computer or human
            // also be sure that only cell within range may be set
            // many TDD purists argue these are all separate tests

            // arrange
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();

            // act
            ticTacToeGame.PlaceMarker(0, 0, CellOwners.Human);
            ticTacToeGame.PlaceMarker(0, 1, CellOwners.Computer);
            ticTacToeGame.PlaceMarker(0, 11, CellOwners.Computer); // should not do anything
            ticTacToeGame.PlaceMarker(0, -1, CellOwners.Computer); // should not do anything

            // assert
            ticTacToeGame.IdentifyMarker(0, 0).ShouldBe(CellOwners.Human);
            ticTacToeGame.IdentifyMarker(0, 1).ShouldBe(CellOwners.Computer);
            ticTacToeGame.IdentifyMarker(0, 2).ShouldBe(CellOwners.Open);
            ticTacToeGame.IdentifyMarker(0, 11).ShouldBe(CellOwners.Error); // out of bounds
            ticTacToeGame.IdentifyMarker(0, -1).ShouldBe(CellOwners.Error);
            ticTacToeGame.IdentifyMarker(0, 3).ShouldBe(CellOwners.Error);
            ticTacToeGame.IdentifyMarker(3, 0).ShouldBe(CellOwners.Error);

            ticTacToeGame.EvaluateBoard().ShouldBeFalse(); // no winner yet
            ticTacToeGame.Winner.ShouldBe(CellOwners.Open); // winner property should now be Open
            ticTacToeGame.IdentifyWinner().ShouldBeEmpty(); // there is no winner
        }

        [Test]
        public void NoWinnerFound()
        {
            // arrange
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();

            // act
            /*
             *      X O X
             *      X X O
             *      O X O
             */
            ticTacToeGame.PlaceMarker(0, 0, CellOwners.Human);
            ticTacToeGame.PlaceMarker(1, 1, CellOwners.Human);
            ticTacToeGame.PlaceMarker(2, 2, CellOwners.Computer);
            ticTacToeGame.PlaceMarker(1, 0, CellOwners.Human);
            ticTacToeGame.PlaceMarker(1, 2, CellOwners.Computer);
            ticTacToeGame.PlaceMarker(0, 1, CellOwners.Computer);
            ticTacToeGame.PlaceMarker(0, 2, CellOwners.Human);
            ticTacToeGame.PlaceMarker(2, 0, CellOwners.Computer);
            ticTacToeGame.PlaceMarker(2, 1, CellOwners.Human);

            // assert
            ticTacToeGame.EvaluateBoard().ShouldBeFalse(); // no winner
            ticTacToeGame.Winner.ShouldBe(CellOwners.Open); // winner property should be Open
            ticTacToeGame.IdentifyWinner().ShouldBeEmpty(); // there is no winner
        }

        public void WinnerHuman()
        {
            // arrange
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();

            // act
            ticTacToeGame.PlaceMarker(0, 0, CellOwners.Human);
            ticTacToeGame.PlaceMarker(1, 1, CellOwners.Human);
            ticTacToeGame.PlaceMarker(2, 2, CellOwners.Human);

            // assert
            ticTacToeGame.EvaluateBoard().ShouldBeTrue(); // winner !
            ticTacToeGame.Winner.ShouldBe(CellOwners.Human);
            ticTacToeGame.IdentifyWinner().ShouldBe("Unnamed Human");
        }

        public void WinnerComputer()
        {
            // arrange
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();

            // act
            ticTacToeGame.PlaceMarker(0, 2, CellOwners.Computer);
            ticTacToeGame.PlaceMarker(1, 1, CellOwners.Computer);
            ticTacToeGame.PlaceMarker(2, 0, CellOwners.Computer);

            // assert
            ticTacToeGame.EvaluateBoard().ShouldBeTrue(); // winner !
            ticTacToeGame.Winner.ShouldBe(CellOwners.Computer);
            ticTacToeGame.IdentifyWinner().ShouldBe("Computer");
        }

        [Test]
        public void SimnpleAutoPlayComputerNoWinnerTest()
        {
            // arrange
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();

            // act
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.AutoPlayComputer();

            // assert
            ticTacToeGame.EvaluateBoard().ShouldBeFalse();
            ticTacToeGame.Winner.ShouldBe(CellOwners.Open);
        }

        [Test]
        public void SimnpleAutoPlayComputerWinnerTest()
        {
            // arrange
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();

            // act
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.AutoPlayComputer();

            // assert
            ticTacToeGame.EvaluateBoard().ShouldBeTrue();
            ticTacToeGame.Winner.ShouldBe(CellOwners.Computer);
        }

        [Test]
        public void AutoPlayComputerWinnerTest()
        {
            // arrange
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();

            // act
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.PlaceMarker(0, 0, CellOwners.Human);
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.PlaceMarker(2, 0, CellOwners.Human);
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.PlaceMarker(1, 0, CellOwners.Human);
            ticTacToeGame.AutoPlayComputer();

            // assert
            ticTacToeGame.EvaluateBoard().ShouldBeTrue();
            ticTacToeGame.Winner.ShouldBe(CellOwners.Computer);
        }

        [Test]
        public void AutoPlayComputerTest()
        {
            // arrange
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();

            // act
            ticTacToeGame.PlaceMarker(0, 0, CellOwners.Human);
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.PlaceMarker(2, 2, CellOwners.Human);
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.PlaceMarker(2, 0, CellOwners.Human);
            ticTacToeGame.AutoPlayComputer();
            ticTacToeGame.PlaceMarker(1, 0, CellOwners.Human);

            // assert
            ticTacToeGame.EvaluateBoard().ShouldBeTrue();
            ticTacToeGame.Winner.ShouldBe(CellOwners.Human);
            ticTacToeGame.IdentifyWinner().ShouldBe("Human");
        }

        [Test]
        public void IdentifyWinnerHumanTest()
        {
            // arrange
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.ResetGrid();

            // act
            ticTacToeGame.PlayerName = "Prof Reynolds";
            ticTacToeGame.PlaceMarker(0, 0, CellOwners.Human);
            ticTacToeGame.PlaceMarker(1, 1, CellOwners.Human);
            ticTacToeGame.PlaceMarker(2, 2, CellOwners.Human);
            ticTacToeGame.EvaluateBoard();

            // assert
            ticTacToeGame.IdentifyWinner().ShouldBe("Prof Reynolds");
        }

    }
}
