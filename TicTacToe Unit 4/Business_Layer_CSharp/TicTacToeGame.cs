using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe_Interfaces;

namespace Business_Layer_CSharp
{
    class TicTacToeGame : ITicTacToeGame
    {
        public string PlayerName { get; set; } = "My Human";

        public CellOwners IdentifyCellOwner(int CellRow, int CellCol)
        {
            throw new NotImplementedException();
        }

        public void SetCellOwner(int CellRow, int CellCol, CellOwners CellOwner)
        {
            throw new NotImplementedException();
        }
    }
}
