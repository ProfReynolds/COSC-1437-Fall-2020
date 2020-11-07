namespace UserInterfaceGraphics
{
    partial class GameCell
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picboxEmoji = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEmoji)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxEmoji
            // 
            this.picboxEmoji.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picboxEmoji.Image = global::UserInterfaceGraphics.Properties.Resources.smiley;
            this.picboxEmoji.Location = new System.Drawing.Point(0, 0);
            this.picboxEmoji.Name = "picboxEmoji";
            this.picboxEmoji.Size = new System.Drawing.Size(150, 150);
            this.picboxEmoji.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxEmoji.TabIndex = 0;
            this.picboxEmoji.TabStop = false;
            this.picboxEmoji.Click += new System.EventHandler(this.picboxEmoji_Click);
            // 
            // GameCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picboxEmoji);
            this.Name = "GameCell";
            ((System.ComponentModel.ISupportInitialize)(this.picboxEmoji)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxEmoji;
    }
}
