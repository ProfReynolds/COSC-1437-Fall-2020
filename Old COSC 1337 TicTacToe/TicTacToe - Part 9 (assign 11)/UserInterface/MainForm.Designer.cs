namespace UserInterface
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
            this.btnGoComputer = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSquare22 = new System.Windows.Forms.Button();
            this.btnSquare21 = new System.Windows.Forms.Button();
            this.btnSquare20 = new System.Windows.Forms.Button();
            this.btnSquare12 = new System.Windows.Forms.Button();
            this.btnSquare11 = new System.Windows.Forms.Button();
            this.btnSquare10 = new System.Windows.Forms.Button();
            this.btnSquare02 = new System.Windows.Forms.Button();
            this.btnSquare01 = new System.Windows.Forms.Button();
            this.btnSquare00 = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGoComputer
            // 
            this.btnGoComputer.Location = new System.Drawing.Point(12, 168);
            this.btnGoComputer.Name = "btnGoComputer";
            this.btnGoComputer.Size = new System.Drawing.Size(90, 60);
            this.btnGoComputer.TabIndex = 2;
            this.btnGoComputer.Text = "GO! Computer";
            this.btnGoComputer.UseVisualStyleBackColor = true;
            this.btnGoComputer.Click += new System.EventHandler(this.btnGoComputer_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(12, 102);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(90, 60);
            this.btnStartGame.TabIndex = 1;
            this.btnStartGame.Text = "Start New Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(111, 34);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(247, 22);
            this.txtPlayerName.TabIndex = 0;
            this.txtPlayerName.TextChanged += new System.EventHandler(this.txtPlayerName_TextChanged);
            this.txtPlayerName.Validated += new System.EventHandler(this.txtPlayerName_Validated);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(9, 37);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(101, 17);
            this.lblPlayerName.TabIndex = 13;
            this.lblPlayerName.Text = "Human Player:";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(346, 405);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 32);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(220, 405);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(120, 32);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSquare22
            // 
            this.btnSquare22.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare22.Location = new System.Drawing.Point(196, 192);
            this.btnSquare22.Name = "btnSquare22";
            this.btnSquare22.Size = new System.Drawing.Size(80, 80);
            this.btnSquare22.TabIndex = 27;
            this.btnSquare22.TabStop = false;
            this.btnSquare22.Text = "?";
            this.btnSquare22.UseVisualStyleBackColor = true;
            this.btnSquare22.Click += new System.EventHandler(this.btnSquare_Common_Click);
            // 
            // btnSquare21
            // 
            this.btnSquare21.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare21.Location = new System.Drawing.Point(110, 192);
            this.btnSquare21.Name = "btnSquare21";
            this.btnSquare21.Size = new System.Drawing.Size(80, 80);
            this.btnSquare21.TabIndex = 26;
            this.btnSquare21.TabStop = false;
            this.btnSquare21.Text = "?";
            this.btnSquare21.UseVisualStyleBackColor = true;
            this.btnSquare21.Click += new System.EventHandler(this.btnSquare_Common_Click);
            // 
            // btnSquare20
            // 
            this.btnSquare20.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare20.Location = new System.Drawing.Point(24, 192);
            this.btnSquare20.Name = "btnSquare20";
            this.btnSquare20.Size = new System.Drawing.Size(80, 80);
            this.btnSquare20.TabIndex = 25;
            this.btnSquare20.TabStop = false;
            this.btnSquare20.Text = "?";
            this.btnSquare20.UseVisualStyleBackColor = true;
            this.btnSquare20.Click += new System.EventHandler(this.btnSquare_Common_Click);
            // 
            // btnSquare12
            // 
            this.btnSquare12.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare12.Location = new System.Drawing.Point(196, 106);
            this.btnSquare12.Name = "btnSquare12";
            this.btnSquare12.Size = new System.Drawing.Size(80, 80);
            this.btnSquare12.TabIndex = 24;
            this.btnSquare12.TabStop = false;
            this.btnSquare12.Text = "?";
            this.btnSquare12.UseVisualStyleBackColor = true;
            this.btnSquare12.Click += new System.EventHandler(this.btnSquare_Common_Click);
            // 
            // btnSquare11
            // 
            this.btnSquare11.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare11.Location = new System.Drawing.Point(110, 106);
            this.btnSquare11.Name = "btnSquare11";
            this.btnSquare11.Size = new System.Drawing.Size(80, 80);
            this.btnSquare11.TabIndex = 23;
            this.btnSquare11.TabStop = false;
            this.btnSquare11.Text = "?";
            this.btnSquare11.UseVisualStyleBackColor = true;
            this.btnSquare11.Click += new System.EventHandler(this.btnSquare_Common_Click);
            // 
            // btnSquare10
            // 
            this.btnSquare10.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare10.Location = new System.Drawing.Point(24, 106);
            this.btnSquare10.Name = "btnSquare10";
            this.btnSquare10.Size = new System.Drawing.Size(80, 80);
            this.btnSquare10.TabIndex = 22;
            this.btnSquare10.TabStop = false;
            this.btnSquare10.Text = "?";
            this.btnSquare10.UseVisualStyleBackColor = true;
            this.btnSquare10.Click += new System.EventHandler(this.btnSquare_Common_Click);
            // 
            // btnSquare02
            // 
            this.btnSquare02.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare02.Location = new System.Drawing.Point(196, 20);
            this.btnSquare02.Name = "btnSquare02";
            this.btnSquare02.Size = new System.Drawing.Size(80, 80);
            this.btnSquare02.TabIndex = 21;
            this.btnSquare02.TabStop = false;
            this.btnSquare02.Text = "?";
            this.btnSquare02.UseVisualStyleBackColor = true;
            this.btnSquare02.Click += new System.EventHandler(this.btnSquare_Common_Click);
            // 
            // btnSquare01
            // 
            this.btnSquare01.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare01.Location = new System.Drawing.Point(110, 20);
            this.btnSquare01.Name = "btnSquare01";
            this.btnSquare01.Size = new System.Drawing.Size(80, 80);
            this.btnSquare01.TabIndex = 20;
            this.btnSquare01.TabStop = false;
            this.btnSquare01.Text = "?";
            this.btnSquare01.UseVisualStyleBackColor = true;
            this.btnSquare01.Click += new System.EventHandler(this.btnSquare_Common_Click);
            // 
            // btnSquare00
            // 
            this.btnSquare00.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare00.Location = new System.Drawing.Point(24, 20);
            this.btnSquare00.Name = "btnSquare00";
            this.btnSquare00.Size = new System.Drawing.Size(80, 80);
            this.btnSquare00.TabIndex = 19;
            this.btnSquare00.TabStop = false;
            this.btnSquare00.Text = "?";
            this.btnSquare00.UseVisualStyleBackColor = true;
            this.btnSquare00.Click += new System.EventHandler(this.btnSquare_Common_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlButtons.Controls.Add(this.btnSquare00);
            this.pnlButtons.Controls.Add(this.btnSquare22);
            this.pnlButtons.Controls.Add(this.btnSquare01);
            this.pnlButtons.Controls.Add(this.btnSquare21);
            this.pnlButtons.Controls.Add(this.btnSquare02);
            this.pnlButtons.Controls.Add(this.btnSquare20);
            this.pnlButtons.Controls.Add(this.btnSquare10);
            this.pnlButtons.Controls.Add(this.btnSquare12);
            this.pnlButtons.Controls.Add(this.btnSquare11);
            this.pnlButtons.Location = new System.Drawing.Point(130, 81);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(300, 300);
            this.pnlButtons.TabIndex = 28;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(482, 449);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGoComputer);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblPlayerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "MainForm";
            this.Text = "CS Game Surface – Mark Reynolds";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoComputer;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnSquare22;
        private System.Windows.Forms.Button btnSquare21;
        private System.Windows.Forms.Button btnSquare20;
        private System.Windows.Forms.Button btnSquare12;
        private System.Windows.Forms.Button btnSquare11;
        private System.Windows.Forms.Button btnSquare10;
        private System.Windows.Forms.Button btnSquare02;
        private System.Windows.Forms.Button btnSquare01;
        private System.Windows.Forms.Button btnSquare00;
        private System.Windows.Forms.Panel pnlButtons;
    }
}

