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
            this.lb_Info = new System.Windows.Forms.Label();
            this.lb_sco = new System.Windows.Forms.Label();
            this.lb_Score = new System.Windows.Forms.Label();
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
            this.pb_Game.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_game_Draw);
            // 
            // gameTime
            // 
            this.gameTime.Interval = 60;
            // 
            // lb_Info
            // 
            this.lb_Info.AutoSize = true;
            this.lb_Info.Location = new System.Drawing.Point(437, 556);
            this.lb_Info.Name = "lb_Info";
            this.lb_Info.Size = new System.Drawing.Size(35, 13);
            this.lb_Info.TabIndex = 1;
            this.lb_Info.Text = "label1";
            // 
            // lb_sco
            // 
            this.lb_sco.AutoSize = true;
            this.lb_sco.Location = new System.Drawing.Point(12, 556);
            this.lb_sco.Name = "lb_sco";
            this.lb_sco.Size = new System.Drawing.Size(41, 13);
            this.lb_sco.TabIndex = 2;
            this.lb_sco.Text = "Score :";
            // 
            // lb_Score
            // 
            this.lb_Score.AutoSize = true;
            this.lb_Score.Location = new System.Drawing.Point(59, 556);
            this.lb_Score.Name = "lb_Score";
            this.lb_Score.Size = new System.Drawing.Size(13, 13);
            this.lb_Score.TabIndex = 3;
            this.lb_Score.Text = "0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.lb_Score);
            this.Controls.Add(this.lb_sco);
            this.Controls.Add(this.lb_Info);
            this.Controls.Add(this.pb_Game);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Main_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Game)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Game;
        private System.Windows.Forms.Timer gameTime;
        private System.Windows.Forms.Label lb_Info;
        private System.Windows.Forms.Label lb_sco;
        private System.Windows.Forms.Label lb_Score;
    }
}

