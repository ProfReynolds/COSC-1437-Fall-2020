using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business_Layer_CSharp;
using TicTacToe_Interfaces;

namespace Business_Layer_Tests
{
    [TestClass]
    public class TicTacToeCell_Tests
    {
        [TestMethod]
        public void Verify_RowID_Initializes_to_0()
        {
            // assign
            var ticTacToeCell = new TicTacToeCell();

            // action

            // assert
            Assert.AreEqual(0,ticTacToeCell.RowID);
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

        [TestMethod]
        public void Verify_RowID_Does_Not_Accept_Values_Above_2()
        {            // assign
            var ticTacToeCell = new TicTacToeCell();

            // action
            ticTacToeCell.RowID = 3;

            // assert
            Assert.AreEqual(0, ticTacToeCell.RowID);
        }

        [TestMethod]
        public void Verify_ColID_Initializes_to_0()
        {
            // assign
            var ticTacToeCell = new TicTacToeCell();

            // action

            // assert
            Assert.AreEqual(0, ticTacToeCell.ColID);
        }

        [TestMethod]
        public void Verify_ColID_Does_Not_Accept_Values_Below_0()
        {
            // assign
            var ticTacToeCell = new TicTacToeCell();

            // action
            ticTacToeCell.ColID = -1;

            // assert
            Assert.AreEqual(0, ticTacToeCell.ColID);
        }

        [TestMethod]
        public void Verify_ColID_Does_Not_Accept_Values_Above_2()
        {
            // assign
            var ticTacToeCell = new TicTacToeCell();

            // action
            ticTacToeCell.ColID = 3;

            // assert
            Assert.AreEqual(0, ticTacToeCell.ColID);
        }

        [TestMethod]
        public void Verify_CellOwner_Accepts_NewValue()
        {
            // assign
            var ticTacToeCell = new TicTacToeCell();

            // action
            ticTacToeCell.CellOwner=CellOwners.Open;

            // assert
            Assert.AreEqual(CellOwners.Open, ticTacToeCell.CellOwner);
        }
    }
}
