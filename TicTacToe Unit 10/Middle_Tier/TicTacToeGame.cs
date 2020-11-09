using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using TicTacToe_Interfaces;

/*
 * ProfReynolds
 */

namespace Middle_Tier
{
    public class TicTacToeGame : ITicTacToeGame
    {
        // unit #9
        /// <summary>
        ///     this delegate defines the event (and includes the parameters from above)
        /// </summary>
        /// <param name="sender">normal event object self reference</param>
        /// <param name="e">row, column, and owner of a marker (square)</param>
        public delegate void CellOwnerChangedHandler(object sender, CellOwnerChangedArgs e);


        public string PlayerName { get; set; } = "The Human";
        public CellOwners Winner { get; private set; }

        /// <summary>
        ///     This class defines a set of cells
        /// </summary>
        private readonly Collection<TicTacToeCell> _ticTacToeCells = new Collection<TicTacToeCell>();

        /// <summary>
        /// Unit #8
        ///     the collection of 9 possible moves, in order of good-ness
        ///     center cell, corner cell, side cell
        /// </summary>
        private Collection<TicTacToeCell> _goodNextMove;

        /// <summary>
        /// Unit #8
        ///     this collection of collections will be used to evaluate winning combinations
        /// </summary>
        private Collection<Collection<TicTacToeCell>> _winningCombinations;

        // notice - no constructor. I dont think one is needed

        public void ResetGrid()
        {
            _ticTacToeCells.Clear(); // resets the collection to empty

            Winner = CellOwners.Open;

            // create the 9 cells
            for (var rowNo = 0; rowNo < 3; rowNo++)
                for (var colNo = 0; colNo < 3; colNo++)
                {
                    _ticTacToeCells.Add(new TicTacToeCell
                    {
                        RowID = rowNo,
                        ColID = colNo
                    });
                }

            // Unit #8
            // // initializes the _goodNextMove collection with the preferred moves
            _goodNextMove = new Collection<TicTacToeCell>()
            {
                _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==1),
                _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==0),
                _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==2),
                _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==0),
                _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==2),
                _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==1),
                _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==0),
                _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==2),
                _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==1),
            };

            // Unit #8
            _winningCombinations = new Collection<Collection<TicTacToeCell>>()
            {
                new Collection<TicTacToeCell>() // loading the first row
                {
                    // the reference to these objects is in the collection - not new ones!
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==2)
                },
                new Collection<TicTacToeCell>() // loading the second row
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==2)
                },
                new Collection<TicTacToeCell>()
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==2)
                },
                new Collection<TicTacToeCell>() // loading the first column
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==0)
                },
                new Collection<TicTacToeCell>()
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==1)
                },
                new Collection<TicTacToeCell>()
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==2),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==2),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==2)
                },
                new Collection<TicTacToeCell>() // loading the first diagonal
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==2)
                },
                new Collection<TicTacToeCell>() // loading final diagonal
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==2),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==0)
                },
            };

            Debug.WriteLine("\nMethod: Reset()");
        }

        public CellOwners IdentifyCellOwner(int CellRow, int CellCol)
        {
            if (_ticTacToeCells.Count == 0) return CellOwners.Error;

            // pre-C# 7 approach
            //var targetCell = _ticTacToeCells
            //    .FirstOrDefault(tttc => tttc.RowID == CellRow && tttc.ColID == CellCol);

            //if (targetCell == null) return CellOwners.Error;

            //return targetCell.CellOwner;


            // C# 7.0 use of null propogation 
            //var targetCell = _ticTacToeCells
            //    .FirstOrDefault(tttc => tttc.RowID == CellRow && tttc.ColID == CellCol);

            //var returnValue = targetCell?.CellOwner ?? CellOwners.Error;

            //return returnValue;

            // C# 7.0 use of null propogation - all in one statement
            var cellOwner =
                _ticTacToeCells
                    .FirstOrDefault(tttc => tttc.RowID == CellRow && tttc.ColID == CellCol)
                    ?.CellOwner
                ?? CellOwners.Error;

            Debug.WriteLine($"Method: IdentifyCellOwner {CellRow}-{CellCol} --> {cellOwner}");

            return cellOwner;
        }

        public void AssignCellOwner(int CellRow, int CellCol, CellOwners CellOwner)
        {
            if (_ticTacToeCells.Count == 0) return;

            if (Winner == CellOwners.Computer || Winner == CellOwners.Human) return;

            var targetCell = _ticTacToeCells
                .FirstOrDefault(tttc => tttc.RowID == CellRow && tttc.ColID == CellCol);

            if (targetCell == null)
                return;

            targetCell.CellOwner = CellOwner;

            Debug.WriteLine($"Method: AssignCellOwner {CellRow}-{CellCol} {CellOwner}");

            // unit #9
            // these will be the arguments used when the event is fired
            var eventArgs = new CellOwnerChangedArgs(CellRow, CellCol, CellOwner);

            //bubble the event up to the parent ( ONLY if the parent is listening )
            CellOwnerChanged?.Invoke(this, eventArgs);
        }

        public void AutoPlayComputer()
        {
            // unit #9
            if (_ticTacToeCells.Count == 0) return;

            // unit #9
            if (Winner == CellOwners.Computer || Winner == CellOwners.Human) return;

            // unit #9
            // checking for possible winning move by the computer
            foreach (var combination in _winningCombinations)
            {
                if (combination[0].CellOwner == CellOwners.Open)
                {
                    if ((combination[1].CellOwner == CellOwners.Computer) &&
                        (combination[2].CellOwner == CellOwners.Computer))
                    {
                        AssignCellOwner(combination[0].RowID, combination[0].ColID, CellOwners.Computer);
                        return;
                    }
                }
                if (combination[1].CellOwner == CellOwners.Open)
                {
                    if ((combination[0].CellOwner == CellOwners.Computer) &&
                        (combination[2].CellOwner == CellOwners.Computer))
                    {
                        AssignCellOwner(combination[1].RowID, combination[1].ColID, CellOwners.Computer);
                        return;
                    }
                }
                if (combination[2].CellOwner == CellOwners.Open)
                {
                    if ((combination[0].CellOwner == CellOwners.Computer) &&
                        (combination[1].CellOwner == CellOwners.Computer))
                    {
                        AssignCellOwner(combination[2].RowID, combination[2].ColID, CellOwners.Computer);
                        return;
                    }
                }
            }

            // checking for possible winning move by the Human
            foreach (var combination in _winningCombinations)
            {
                if (combination[0].CellOwner == CellOwners.Open)
                {
                    if ((combination[1].CellOwner == CellOwners.Human) &&
                        (combination[2].CellOwner == CellOwners.Human))
                    {
                        AssignCellOwner(combination[0].RowID, combination[0].ColID, CellOwners.Computer);
                        return;
                    }
                }
                if (combination[1].CellOwner == CellOwners.Open)
                {
                    if ((combination[0].CellOwner == CellOwners.Human) &&
                        (combination[2].CellOwner == CellOwners.Human))
                    {
                        AssignCellOwner(combination[1].RowID, combination[1].ColID, CellOwners.Computer);
                        return;
                    }
                }
                if (combination[2].CellOwner == CellOwners.Open)
                {
                    if ((combination[0].CellOwner == CellOwners.Human) &&
                        (combination[1].CellOwner == CellOwners.Human))
                    {
                        AssignCellOwner(combination[2].RowID, combination[2].ColID, CellOwners.Computer);
                        return;
                    }
                }
            }

            // unit #8
            foreach (var targetCell in _goodNextMove)
            {
                if (targetCell.CellOwner == CellOwners.Open)
                {
                    AssignCellOwner(targetCell.RowID, targetCell.ColID, CellOwners.Computer);
                    //targetCell.CellOwner = CellOwners.Computer;
                    return;
                }
            }

        }

        public bool CheckForWinner()
        {
            /*
             * All of these repetitious checks are replaced by ...
             *
            // first row
            if ((IdentifyCellOwner(0, 0) == CellOwners.Human) &&
                (IdentifyCellOwner(0, 1) == CellOwners.Human) &&
                (IdentifyCellOwner(0, 2) == CellOwners.Human))
            {
                Winner = CellOwners.Human;
                return true;
            }

            // 2nd row
            if ((IdentifyCellOwner(1, 0) == CellOwners.Human) &&
                (IdentifyCellOwner(1, 1) == CellOwners.Human) &&
                (IdentifyCellOwner(1, 2) == CellOwners.Human))
            {
                Winner = CellOwners.Human;
                return true;
            }

            // 3rd row
            if ((IdentifyCellOwner(2, 0) == CellOwners.Human) &&
                (IdentifyCellOwner(2, 1) == CellOwners.Human) &&
                (IdentifyCellOwner(2, 2) == CellOwners.Human))
            {
                Winner = CellOwners.Human;
                return true;
            }

            // 1st col
            if ((IdentifyCellOwner(0, 0) == CellOwners.Human) &&
                (IdentifyCellOwner(1, 0) == CellOwners.Human) &&
                (IdentifyCellOwner(2, 0) == CellOwners.Human))
            {
                Winner = CellOwners.Human;
                return true;
            }

            // 2nd col
            if ((IdentifyCellOwner(0, 1) == CellOwners.Human) &&
                (IdentifyCellOwner(1, 1) == CellOwners.Human) &&
                (IdentifyCellOwner(2, 1) == CellOwners.Human))
            {
                Winner = CellOwners.Human;
                return true;
            }

            // 3rd col
            if ((IdentifyCellOwner(0, 2) == CellOwners.Human) &&
                (IdentifyCellOwner(1, 2) == CellOwners.Human) &&
                (IdentifyCellOwner(2, 2) == CellOwners.Human))
            {
                Winner = CellOwners.Human;
                return true;
            }

            // 1st diag
            if ((IdentifyCellOwner(0, 0) == CellOwners.Human) &&
                (IdentifyCellOwner(1, 1) == CellOwners.Human) &&
                (IdentifyCellOwner(2, 2) == CellOwners.Human))
            {
                Winner = CellOwners.Human;
                return true;
            }

            // 2nd diag
            if ((IdentifyCellOwner(0, 2) == CellOwners.Human) &&
                (IdentifyCellOwner(1, 1) == CellOwners.Human) &&
                (IdentifyCellOwner(2, 0) == CellOwners.Human))
            {
                Winner = CellOwners.Human;
                return true;
            }





            // first row
            if ((IdentifyCellOwner(0, 0) == CellOwners.Computer) &&
                (IdentifyCellOwner(0, 1) == CellOwners.Computer) &&
                (IdentifyCellOwner(0, 2) == CellOwners.Computer))
            {
                Winner = CellOwners.Computer;
                return true;
            }

            // 2nd row
            if ((IdentifyCellOwner(1, 0) == CellOwners.Computer) &&
                (IdentifyCellOwner(1, 1) == CellOwners.Computer) &&
                (IdentifyCellOwner(1, 2) == CellOwners.Computer))
            {
                Winner = CellOwners.Computer;
                return true;
            }

            // 3rd row
            if ((IdentifyCellOwner(2, 0) == CellOwners.Computer) &&
                (IdentifyCellOwner(2, 1) == CellOwners.Computer) &&
                (IdentifyCellOwner(2, 2) == CellOwners.Computer))
            {
                Winner = CellOwners.Computer;
                return true;
            }

            // 1st col
            if ((IdentifyCellOwner(0, 0) == CellOwners.Computer) &&
                (IdentifyCellOwner(1, 0) == CellOwners.Computer) &&
                (IdentifyCellOwner(2, 0) == CellOwners.Computer))
            {
                Winner = CellOwners.Computer;
                return true;
            }

            // 2nd col
            if ((IdentifyCellOwner(0, 1) == CellOwners.Computer) &&
                (IdentifyCellOwner(1, 1) == CellOwners.Computer) &&
                (IdentifyCellOwner(2, 1) == CellOwners.Computer))
            {
                Winner = CellOwners.Computer;
                return true;
            }

            // 3rd col
            if ((IdentifyCellOwner(0, 2) == CellOwners.Computer) &&
                (IdentifyCellOwner(1, 2) == CellOwners.Computer) &&
                (IdentifyCellOwner(2, 2) == CellOwners.Computer))
            {
                Winner = CellOwners.Computer;
                return true;
            }

            // 1st diag
            if ((IdentifyCellOwner(0, 0) == CellOwners.Computer) &&
                (IdentifyCellOwner(1, 1) == CellOwners.Computer) &&
                (IdentifyCellOwner(2, 2) == CellOwners.Computer))
            {
                Winner = CellOwners.Computer;
                return true;
            }

            // 2nd diag
            if ((IdentifyCellOwner(0, 2) == CellOwners.Computer) &&
                (IdentifyCellOwner(1, 1) == CellOwners.Computer) &&
                (IdentifyCellOwner(2, 0) == CellOwners.Computer))
            {
                Winner = CellOwners.Computer;
                return true;
            }
             *
             */



            // unit #8
            foreach (var combination in _winningCombinations)
            {
                // combination is a collection of 3 TicTacToe cell references
                var firstCell = combination[0];

                if ((firstCell.CellOwner != CellOwners.Computer) &&
                    (firstCell.CellOwner != CellOwners.Human)) continue;

                if ((firstCell.CellOwner != combination[1].CellOwner) ||
                    (firstCell.CellOwner != combination[2].CellOwner)) continue;

                Winner = firstCell.CellOwner;

                Debug.WriteLine($"Method: CheckForWinner {Winner}");

                return true;
            }

            Debug.WriteLine($"Method: CheckForWinner {Winner}");

            return false;
        }

        public string IdentifyWinner()
        {
            switch (Winner)
            {
                case CellOwners.Computer:
                    return "Computer";

                case CellOwners.Human:
                    return PlayerName == "" ? "Unnamed Human" : PlayerName;

                case CellOwners.Open:
                    return string.Empty;

                default:
                    return "Error";
            }
        }

        // unit #9
        /// <summary>
        ///     The exposed event to the MainForm
        /// </summary>
        public event CellOwnerChangedHandler CellOwnerChanged;

        /// <inheritdoc />
        /// <summary>
        ///     defines the parameters that are returned to the parent form when the event is triggered
        /// </summary>
        public class CellOwnerChangedArgs : EventArgs
        {
            public CellOwnerChangedArgs(int rowID, int colID, CellOwners cellOwner)
            {
                RowID = rowID;
                ColID = colID;
                CellOwner = cellOwner;
                Debug.WriteLine($"Method: CellOwnerChangedArgs {RowID}-{ColID} {CellOwner}");
            }

            public int RowID { get; }
            public int ColID { get; }
            public CellOwners CellOwner { get; }
        }
    }
}