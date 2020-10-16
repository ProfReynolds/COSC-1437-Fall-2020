using System;
using TicTacToe_Interfaces;

/*
 * ProfReynolds
 */

namespace Middle_Tier
{
    public class TicTacToeGame : ITicTacToeGame
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
