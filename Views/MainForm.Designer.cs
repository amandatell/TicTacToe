namespace TicTacToe
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
            this.txtXPlayer = new System.Windows.Forms.TextBox();
            this.txtOPlayer = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnQuickStart = new System.Windows.Forms.Button();
            this.lstStats = new System.Windows.Forms.ListBox();
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblXPlayer = new System.Windows.Forms.Label();
            this.lblOPlayer = new System.Windows.Forms.Label();
            this.grpPlayers = new System.Windows.Forms.GroupBox();
            this.btnSwap = new System.Windows.Forms.Button();
            this.lblTurn = new System.Windows.Forms.Label();
            this.a3 = new System.Windows.Forms.Button();
            this.grpBoard = new System.Windows.Forms.GroupBox();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.lblPlaying = new System.Windows.Forms.Label();
            this.lblPlayerNames = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.grpStats.SuspendLayout();
            this.grpPlayers.SuspendLayout();
            this.grpBoard.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtXPlayer
            // 
            this.txtXPlayer.Location = new System.Drawing.Point(83, 36);
            this.txtXPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.txtXPlayer.Name = "txtXPlayer";
            this.txtXPlayer.Size = new System.Drawing.Size(158, 20);
            this.txtXPlayer.TabIndex = 2;
            this.txtXPlayer.TextChanged += new System.EventHandler(this.txtXPlayer_TextChanged);
            // 
            // txtOPlayer
            // 
            this.txtOPlayer.Location = new System.Drawing.Point(83, 60);
            this.txtOPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.txtOPlayer.Name = "txtOPlayer";
            this.txtOPlayer.Size = new System.Drawing.Size(158, 20);
            this.txtOPlayer.TabIndex = 3;
            this.txtOPlayer.TextChanged += new System.EventHandler(this.txtOPlayer_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(124, 93);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(95, 34);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnQuickStart
            // 
            this.btnQuickStart.Location = new System.Drawing.Point(756, 127);
            this.btnQuickStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuickStart.Name = "btnQuickStart";
            this.btnQuickStart.Size = new System.Drawing.Size(89, 34);
            this.btnQuickStart.TabIndex = 0;
            this.btnQuickStart.Text = "Quick Start";
            this.btnQuickStart.UseVisualStyleBackColor = true;
            this.btnQuickStart.Click += new System.EventHandler(this.btnQuickStart_Click);
            // 
            // lstStats
            // 
            this.lstStats.Font = new System.Drawing.Font("Courier New", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStats.FormattingEnabled = true;
            this.lstStats.ItemHeight = 12;
            this.lstStats.Location = new System.Drawing.Point(16, 37);
            this.lstStats.Name = "lstStats";
            this.lstStats.Size = new System.Drawing.Size(274, 136);
            this.lstStats.TabIndex = 7;
            // 
            // grpStats
            // 
            this.grpStats.Controls.Add(this.label4);
            this.grpStats.Controls.Add(this.label3);
            this.grpStats.Controls.Add(this.label2);
            this.grpStats.Controls.Add(this.lstStats);
            this.grpStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStats.Location = new System.Drawing.Point(625, 355);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(313, 208);
            this.grpStats.TabIndex = 8;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "Statistics";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Symbol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // lblXPlayer
            // 
            this.lblXPlayer.AutoSize = true;
            this.lblXPlayer.Location = new System.Drawing.Point(13, 36);
            this.lblXPlayer.Name = "lblXPlayer";
            this.lblXPlayer.Size = new System.Drawing.Size(46, 13);
            this.lblXPlayer.TabIndex = 1;
            this.lblXPlayer.Text = "Player X";
            // 
            // lblOPlayer
            // 
            this.lblOPlayer.AutoSize = true;
            this.lblOPlayer.Location = new System.Drawing.Point(13, 63);
            this.lblOPlayer.Name = "lblOPlayer";
            this.lblOPlayer.Size = new System.Drawing.Size(47, 13);
            this.lblOPlayer.TabIndex = 2;
            this.lblOPlayer.Text = "Player O";
            // 
            // grpPlayers
            // 
            this.grpPlayers.Controls.Add(this.txtXPlayer);
            this.grpPlayers.Controls.Add(this.txtOPlayer);
            this.grpPlayers.Controls.Add(this.btnStart);
            this.grpPlayers.Controls.Add(this.lblXPlayer);
            this.grpPlayers.Controls.Add(this.lblOPlayer);
            this.grpPlayers.Location = new System.Drawing.Point(625, 210);
            this.grpPlayers.Name = "grpPlayers";
            this.grpPlayers.Size = new System.Drawing.Size(313, 139);
            this.grpPlayers.TabIndex = 3;
            this.grpPlayers.TabStop = false;
            this.grpPlayers.Text = "Players";
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(888, 186);
            this.btnSwap.Margin = new System.Windows.Forms.Padding(2);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(49, 25);
            this.btnSwap.TabIndex = 2;
            this.btnSwap.Text = "Swap";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.Location = new System.Drawing.Point(690, 69);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(0, 16);
            this.lblTurn.TabIndex = 16;
            // 
            // a3
            // 
            this.a3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a3.Location = new System.Drawing.Point(389, 32);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(173, 154);
            this.a3.TabIndex = 17;
            this.a3.UseVisualStyleBackColor = false;
            this.a3.Click += new System.EventHandler(this.a3_Click);
            // 
            // grpBoard
            // 
            this.grpBoard.Controls.Add(this.b2);
            this.grpBoard.Controls.Add(this.b3);
            this.grpBoard.Controls.Add(this.c3);
            this.grpBoard.Controls.Add(this.c2);
            this.grpBoard.Controls.Add(this.c1);
            this.grpBoard.Controls.Add(this.b1);
            this.grpBoard.Controls.Add(this.a1);
            this.grpBoard.Controls.Add(this.a2);
            this.grpBoard.Controls.Add(this.a3);
            this.grpBoard.Location = new System.Drawing.Point(12, 37);
            this.grpBoard.Name = "grpBoard";
            this.grpBoard.Size = new System.Drawing.Size(587, 533);
            this.grpBoard.TabIndex = 10;
            this.grpBoard.TabStop = false;
            this.grpBoard.Text = "Board";
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(210, 190);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(173, 154);
            this.b2.TabIndex = 17;
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(389, 190);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(173, 154);
            this.b3.TabIndex = 17;
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // c3
            // 
            this.c3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.c3.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c3.Location = new System.Drawing.Point(389, 350);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(173, 154);
            this.c3.TabIndex = 17;
            this.c3.UseVisualStyleBackColor = false;
            this.c3.Click += new System.EventHandler(this.c3_Click);
            // 
            // c2
            // 
            this.c2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c2.Location = new System.Drawing.Point(210, 350);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(173, 154);
            this.c2.TabIndex = 17;
            this.c2.UseVisualStyleBackColor = false;
            this.c2.Click += new System.EventHandler(this.c2_Click);
            // 
            // c1
            // 
            this.c1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1.Location = new System.Drawing.Point(31, 350);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(173, 154);
            this.c1.TabIndex = 17;
            this.c1.UseVisualStyleBackColor = false;
            this.c1.Click += new System.EventHandler(this.c1_Click);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(31, 190);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(173, 154);
            this.b1.TabIndex = 17;
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // a1
            // 
            this.a1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a1.Location = new System.Drawing.Point(31, 32);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(173, 154);
            this.a1.TabIndex = 17;
            this.a1.UseVisualStyleBackColor = false;
            this.a1.Click += new System.EventHandler(this.a1_Click);
            // 
            // a2
            // 
            this.a2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a2.Location = new System.Drawing.Point(210, 32);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(173, 154);
            this.a2.TabIndex = 17;
            this.a2.UseVisualStyleBackColor = false;
            this.a2.Click += new System.EventHandler(this.a2_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(730, 576);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(82, 34);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip.Size = new System.Drawing.Size(951, 24);
            this.menuStrip.TabIndex = 20;
            // 
            // toolHelp
            // 
            this.toolHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAbout});
            this.toolHelp.Name = "toolHelp";
            this.toolHelp.Size = new System.Drawing.Size(44, 22);
            this.toolHelp.Text = "Help";
            // 
            // toolAbout
            // 
            this.toolAbout.Name = "toolAbout";
            this.toolAbout.Size = new System.Drawing.Size(107, 22);
            this.toolAbout.Text = "About";
            this.toolAbout.Click += new System.EventHandler(this.toolAbout_Click);
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSymbol.Location = new System.Drawing.Point(772, 46);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(0, 55);
            this.lblSymbol.TabIndex = 21;
            // 
            // lblPlaying
            // 
            this.lblPlaying.AutoSize = true;
            this.lblPlaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaying.Location = new System.Drawing.Point(622, 180);
            this.lblPlaying.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlaying.Name = "lblPlaying";
            this.lblPlaying.Size = new System.Drawing.Size(58, 15);
            this.lblPlaying.TabIndex = 22;
            this.lblPlaying.Text = "Playing:";
            // 
            // lblPlayerNames
            // 
            this.lblPlayerNames.AutoSize = true;
            this.lblPlayerNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerNames.Location = new System.Drawing.Point(686, 180);
            this.lblPlayerNames.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerNames.Name = "lblPlayerNames";
            this.lblPlayerNames.Size = new System.Drawing.Size(0, 15);
            this.lblPlayerNames.TabIndex = 23;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(888, 158);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 25);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(951, 620);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.lblPlayerNames);
            this.Controls.Add(this.lblPlaying);
            this.Controls.Add(this.lblSymbol);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.grpBoard);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.grpPlayers);
            this.Controls.Add(this.grpStats);
            this.Controls.Add(this.btnQuickStart);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            this.grpPlayers.ResumeLayout(false);
            this.grpPlayers.PerformLayout();
            this.grpBoard.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtXPlayer;
        private System.Windows.Forms.TextBox txtOPlayer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnQuickStart;
        private System.Windows.Forms.ListBox lstStats;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblXPlayer;
        private System.Windows.Forms.Label lblOPlayer;
        private System.Windows.Forms.GroupBox grpPlayers;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.GroupBox grpBoard;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolHelp;
        private System.Windows.Forms.ToolStripMenuItem toolAbout;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.Label lblPlaying;
        private System.Windows.Forms.Label lblPlayerNames;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSwap;
    }
}

