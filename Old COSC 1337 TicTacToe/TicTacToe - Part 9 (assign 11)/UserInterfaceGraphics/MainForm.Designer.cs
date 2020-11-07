namespace UserInterfaceGraphics
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gameCell1 = new UserInterfaceGraphics.GameCell();
            this.gameCell2 = new UserInterfaceGraphics.GameCell();
            this.gameCell3 = new UserInterfaceGraphics.GameCell();
            this.gameCell4 = new UserInterfaceGraphics.GameCell();
            this.gameCell5 = new UserInterfaceGraphics.GameCell();
            this.gameCell6 = new UserInterfaceGraphics.GameCell();
            this.gameCell7 = new UserInterfaceGraphics.GameCell();
            this.gameCell8 = new UserInterfaceGraphics.GameCell();
            this.gameCell9 = new UserInterfaceGraphics.GameCell();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnGoComputer = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Controls.Add(this.gameCell1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gameCell2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gameCell3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.gameCell4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gameCell5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.gameCell6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.gameCell7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gameCell8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.gameCell9, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(232, 79);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 300);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gameCell1
            // 
            this.gameCell1.CellColNo = 0;
            this.gameCell1.CellOwner = TheBrain.CellOwners.Error;
            this.gameCell1.CellRowNo = 0;
            this.gameCell1.Location = new System.Drawing.Point(3, 3);
            this.gameCell1.Name = "gameCell1";
            this.gameCell1.Size = new System.Drawing.Size(93, 93);
            this.gameCell1.TabIndex = 0;
            this.gameCell1.EmojiClick += new System.EventHandler(this.EmojiMasterClick);
            // 
            // gameCell2
            // 
            this.gameCell2.CellColNo = 1;
            this.gameCell2.CellOwner = TheBrain.CellOwners.Error;
            this.gameCell2.CellRowNo = 0;
            this.gameCell2.Location = new System.Drawing.Point(102, 3);
            this.gameCell2.Name = "gameCell2";
            this.gameCell2.Size = new System.Drawing.Size(96, 93);
            this.gameCell2.TabIndex = 1;
            this.gameCell2.EmojiClick += new System.EventHandler(this.EmojiMasterClick);
            // 
            // gameCell3
            // 
            this.gameCell3.CellColNo = 2;
            this.gameCell3.CellOwner = TheBrain.CellOwners.Error;
            this.gameCell3.CellRowNo = 0;
            this.gameCell3.Location = new System.Drawing.Point(204, 3);
            this.gameCell3.Name = "gameCell3";
            this.gameCell3.Size = new System.Drawing.Size(93, 93);
            this.gameCell3.TabIndex = 2;
            this.gameCell3.EmojiClick += new System.EventHandler(this.EmojiMasterClick);
            // 
            // gameCell4
            // 
            this.gameCell4.CellColNo = 0;
            this.gameCell4.CellOwner = TheBrain.CellOwners.Error;
            this.gameCell4.CellRowNo = 1;
            this.gameCell4.Location = new System.Drawing.Point(3, 102);
            this.gameCell4.Name = "gameCell4";
            this.gameCell4.Size = new System.Drawing.Size(93, 96);
            this.gameCell4.TabIndex = 3;
            this.gameCell4.EmojiClick += new System.EventHandler(this.EmojiMasterClick);
            // 
            // gameCell5
            // 
            this.gameCell5.CellColNo = 1;
            this.gameCell5.CellOwner = TheBrain.CellOwners.Error;
            this.gameCell5.CellRowNo = 1;
            this.gameCell5.Location = new System.Drawing.Point(102, 102);
            this.gameCell5.Name = "gameCell5";
            this.gameCell5.Size = new System.Drawing.Size(96, 96);
            this.gameCell5.TabIndex = 4;
            this.gameCell5.EmojiClick += new System.EventHandler(this.EmojiMasterClick);
            // 
            // gameCell6
            // 
            this.gameCell6.CellColNo = 2;
            this.gameCell6.CellOwner = TheBrain.CellOwners.Error;
            this.gameCell6.CellRowNo = 1;
            this.gameCell6.Location = new System.Drawing.Point(204, 102);
            this.gameCell6.Name = "gameCell6";
            this.gameCell6.Size = new System.Drawing.Size(93, 96);
            this.gameCell6.TabIndex = 5;
            this.gameCell6.EmojiClick += new System.EventHandler(this.EmojiMasterClick);
            // 
            // gameCell7
            // 
            this.gameCell7.CellColNo = 0;
            this.gameCell7.CellOwner = TheBrain.CellOwners.Error;
            this.gameCell7.CellRowNo = 2;
            this.gameCell7.Location = new System.Drawing.Point(3, 204);
            this.gameCell7.Name = "gameCell7";
            this.gameCell7.Size = new System.Drawing.Size(93, 93);
            this.gameCell7.TabIndex = 6;
            this.gameCell7.EmojiClick += new System.EventHandler(this.EmojiMasterClick);
            // 
            // gameCell8
            // 
            this.gameCell8.CellColNo = 1;
            this.gameCell8.CellOwner = TheBrain.CellOwners.Error;
            this.gameCell8.CellRowNo = 2;
            this.gameCell8.Location = new System.Drawing.Point(102, 204);
            this.gameCell8.Name = "gameCell8";
            this.gameCell8.Size = new System.Drawing.Size(96, 93);
            this.gameCell8.TabIndex = 7;
            this.gameCell8.EmojiClick += new System.EventHandler(this.EmojiMasterClick);
            // 
            // gameCell9
            // 
            this.gameCell9.CellColNo = 2;
            this.gameCell9.CellOwner = TheBrain.CellOwners.Error;
            this.gameCell9.CellRowNo = 2;
            this.gameCell9.Location = new System.Drawing.Point(204, 204);
            this.gameCell9.Name = "gameCell9";
            this.gameCell9.Size = new System.Drawing.Size(93, 93);
            this.gameCell9.TabIndex = 8;
            this.gameCell9.EmojiClick += new System.EventHandler(this.EmojiMasterClick);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(374, 409);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(120, 32);
            this.btnAbout.TabIndex = 17;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(500, 409);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 32);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGoComputer
            // 
            this.btnGoComputer.Location = new System.Drawing.Point(23, 127);
            this.btnGoComputer.Name = "btnGoComputer";
            this.btnGoComputer.Size = new System.Drawing.Size(142, 60);
            this.btnGoComputer.TabIndex = 16;
            this.btnGoComputer.Text = "GO! Computer";
            this.btnGoComputer.UseVisualStyleBackColor = true;
            this.btnGoComputer.Click += new System.EventHandler(this.btnGoComputer_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(23, 61);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(142, 60);
            this.btnStartGame.TabIndex = 15;
            this.btnStartGame.Text = "Start New Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(122, 17);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(247, 22);
            this.txtPlayerName.TabIndex = 14;
            this.txtPlayerName.TextChanged += new System.EventHandler(this.txtPlayerName_TextChanged);
            this.txtPlayerName.Validated += new System.EventHandler(this.txtPlayerName_Validated);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(20, 20);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(101, 17);
            this.lblPlayerName.TabIndex = 19;
            this.lblPlayerName.Text = "Human Player:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGoComputer);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "UserControl Game Surface – Mark Reynolds";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGoComputer;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
        private GameCell gameCell1;
        private GameCell gameCell2;
        private GameCell gameCell3;
        private GameCell gameCell4;
        private GameCell gameCell5;
        private GameCell gameCell6;
        private GameCell gameCell7;
        private GameCell gameCell8;
        private GameCell gameCell9;
    }
}

