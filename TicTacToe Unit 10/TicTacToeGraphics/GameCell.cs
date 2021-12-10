﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using TicTacToe_Interfaces;

namespace TicTacToeGraphics
{
    public partial class GameCell : UserControl
    {
        public GameCell()
        {
            InitializeComponent();
        }

        public delegate void CellOwnerChangedHandler(object sender);
        public event CellOwnerChangedHandler CellOwnerChanged;

        public int GameCellRow { get; set; }

        public int GameCellCol { get; set; }

        private CellOwners _cellOwner = CellOwners.Error;

        /// <summary>
        /// This property will hold the owner of the GameCell
        /// </summary>
        public CellOwners GameCellOwner
        {
            get { return _cellOwner; }
            set
            {
                _cellOwner = value;
                switch (value)
                {
                    case CellOwners.Error:
                        this.BackgroundImage = Properties.Resources.smiley;
                        break;
                    case CellOwners.Open:
                        this.BackgroundImage = Properties.Resources.OpenCell;
                        break;
                    case CellOwners.Human:
                        this.BackgroundImage = Properties.Resources.Splinter;
                        break;
                    case CellOwners.Computer:
                        this.BackgroundImage = Properties.Resources.Shredder;
                        break;
                    default:
                        this.BackgroundImage = Properties.Resources.smiley;
                        break;
                }
            }
        }

        private void GameCell_Click(object sender, EventArgs e)
        {
            CellOwnerChanged?.Invoke(this);
        }
    }
}
