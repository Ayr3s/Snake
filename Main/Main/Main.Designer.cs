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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.allgemeinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Player2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Game)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Game
            // 
            this.pb_Game.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pb_Game.Location = new System.Drawing.Point(12, 36);
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
            this.lb_Info.Location = new System.Drawing.Point(439, 591);
            this.lb_Info.Name = "lb_Info";
            this.lb_Info.Size = new System.Drawing.Size(35, 13);
            this.lb_Info.TabIndex = 1;
            this.lb_Info.Text = "label1";
            // 
            // lb_sco
            // 
            this.lb_sco.AutoSize = true;
            this.lb_sco.Location = new System.Drawing.Point(12, 591);
            this.lb_sco.Name = "lb_sco";
            this.lb_sco.Size = new System.Drawing.Size(41, 13);
            this.lb_sco.TabIndex = 2;
            this.lb_sco.Text = "Score :";
            // 
            // lb_Score
            // 
            this.lb_Score.AutoSize = true;
            this.lb_Score.Location = new System.Drawing.Point(59, 591);
            this.lb_Score.Name = "lb_Score";
            this.lb_Score.Size = new System.Drawing.Size(13, 13);
            this.lb_Score.TabIndex = 3;
            this.lb_Score.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allgemeinToolStripMenuItem,
            this.einstellungenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // allgemeinToolStripMenuItem
            // 
            this.allgemeinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scoreboardToolStripMenuItem});
            this.allgemeinToolStripMenuItem.Name = "allgemeinToolStripMenuItem";
            this.allgemeinToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.allgemeinToolStripMenuItem.Text = "Allgemein";
            // 
            // scoreboardToolStripMenuItem
            // 
            this.scoreboardToolStripMenuItem.Name = "scoreboardToolStripMenuItem";
            this.scoreboardToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.scoreboardToolStripMenuItem.Text = "Scoreboard";
            this.scoreboardToolStripMenuItem.Click += new System.EventHandler(this.scoreboardToolStripMenuItem_Click);
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Player2});
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // Player2
            // 
            this.Player2.CheckOnClick = true;
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(160, 22);
            this.Player2.Text = "2 Spieler-Modus";
            this.Player2.Click += new System.EventHandler(this.Player2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 626);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Score);
            this.Controls.Add(this.lb_sco);
            this.Controls.Add(this.lb_Info);
            this.Controls.Add(this.pb_Game);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Main_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Game)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Game;
        private System.Windows.Forms.Timer gameTime;
        private System.Windows.Forms.Label lb_Info;
        private System.Windows.Forms.Label lb_sco;
        private System.Windows.Forms.Label lb_Score;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem allgemeinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Player2;
        private System.Windows.Forms.Label label1;
    }
}

