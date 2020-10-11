using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe_Interfaces;

namespace Business_Layer_CSharp
{
    public class TicTacToeGame : ITicTacToeGame
    {
        public string PlayerName { get; set; } = "My Human";
        public CellOwners Winner { get; private set; }

        public void ResetGrid()
        {
            throw new NotImplementedException();
        }

        public CellOwners IdentifyCellOwner(int CellRow, int CellCol)
        {
            throw new NotImplementedException();
        }

        public void AssignCellOwner(int CellRow, int CellCol, CellOwners CellOwner)
        {
            throw new NotImplementedException();
        }

        public void AutoPlayComputer()
        {
            throw new NotImplementedException();
        }

        public bool CheckForWinner()
        {
            return false;
        }

        public string IdentifyWinner()
        {
            return "";
        }

    }
}