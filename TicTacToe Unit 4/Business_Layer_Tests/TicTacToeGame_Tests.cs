using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business_Layer_CSharp;
using TicTacToe_Interfaces;

namespace Business_Layer_Tests
{
    [TestClass]
    public class TicTacToeGame_Tests
    {
        [TestMethod]
        public void Verify_PlayerName_Initializes_Properly()
        {
            // assign
            var ticTacToeGame = new TicTacToeGame();

            // action

            // assert
            Assert.AreEqual("My Human", ticTacToeGame.PlayerName);
        }

        [TestMethod]
        public void Verify_PlayerName_Rejects_Blank()
        {
            // assign
            var ticTacToeGame = new TicTacToeGame();

            // action
            ticTacToeGame.PlayerName = "";

            // assert
            Assert.AreNotEqual("", ticTacToeGame.PlayerName);
            Assert.AreEqual("My Human", ticTacToeGame.PlayerName);
        }

        [TestMethod]
        public void Verify_PlayerName_Accepts_Entry()
        {
            // assign
            var desiredValue = "Prof Reynolds";
            var ticTacToeGame = new TicTacToeGame();

            // action
            ticTacToeGame.PlayerName = desiredValue;

            // assert
            Assert.AreEqual(desiredValue, ticTacToeGame.PlayerName);
        }

        [TestMethod]
        public void Verify_RowID_Does_Not_Accept_Values_Below_0()
        {
            // assign
            var ticTacToeCell = new TicTacToeCell();

            // action
            ticTacToeCell.RowID = -1;

            // assert
            Assert.AreEqual(0, ticTacToeCell.RowID);
        }

    }
}
