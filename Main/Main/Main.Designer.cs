namespace Main
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pb_Game = new System.Windows.Forms.PictureBox();
            this.gameTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Game)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Game
            // 
            this.pb_Game.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pb_Game.Location = new System.Drawing.Point(12, 12);
            this.pb_Game.Name = "pb_Game";
            this.pb_Game.Size = new System.Drawing.Size(960, 526);
            this.pb_Game.TabIndex = 0;
            this.pb_Game.TabStop = false;
            // 
            // gameTime
            // 
            this.gameTime.Interval = 60;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pb_Game);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Game)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Game;
        private System.Windows.Forms.Timer gameTime;
    }
}

