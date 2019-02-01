namespace Bowlingspelet
{
    partial class game
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
            this.gamePnl = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.player2NameTxt = new System.Windows.Forms.TextBox();
            this.player1NameTxt = new System.Windows.Forms.TextBox();
            this.player2NameLbl = new System.Windows.Forms.Label();
            this.player1NameLbl = new System.Windows.Forms.Label();
            this.enterNamesLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.player1SBLbl = new System.Windows.Forms.Label();
            this.player2SBLbl = new System.Windows.Forms.Label();
            this.gamePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePnl
            // 
            this.gamePnl.Controls.Add(this.cancelBtn);
            this.gamePnl.Controls.Add(this.acceptBtn);
            this.gamePnl.Controls.Add(this.player2NameTxt);
            this.gamePnl.Controls.Add(this.player1NameTxt);
            this.gamePnl.Controls.Add(this.player2NameLbl);
            this.gamePnl.Controls.Add(this.player1NameLbl);
            this.gamePnl.Controls.Add(this.enterNamesLbl);
            this.gamePnl.Location = new System.Drawing.Point(0, 0);
            this.gamePnl.Name = "gamePnl";
            this.gamePnl.Size = new System.Drawing.Size(798, 453);
            this.gamePnl.TabIndex = 0;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(378, 251);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(106, 39);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // acceptBtn
            // 
            this.acceptBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptBtn.Location = new System.Drawing.Point(254, 251);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(106, 39);
            this.acceptBtn.TabIndex = 5;
            this.acceptBtn.Text = "Accept";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // player2NameTxt
            // 
            this.player2NameTxt.Location = new System.Drawing.Point(319, 225);
            this.player2NameTxt.Name = "player2NameTxt";
            this.player2NameTxt.Size = new System.Drawing.Size(165, 20);
            this.player2NameTxt.TabIndex = 4;
            this.player2NameTxt.Text = "Player2";
            // 
            // player1NameTxt
            // 
            this.player1NameTxt.Location = new System.Drawing.Point(319, 191);
            this.player1NameTxt.Name = "player1NameTxt";
            this.player1NameTxt.Size = new System.Drawing.Size(165, 20);
            this.player1NameTxt.TabIndex = 3;
            this.player1NameTxt.Text = "Player1";
            // 
            // player2NameLbl
            // 
            this.player2NameLbl.AutoSize = true;
            this.player2NameLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2NameLbl.Location = new System.Drawing.Point(250, 225);
            this.player2NameLbl.Name = "player2NameLbl";
            this.player2NameLbl.Size = new System.Drawing.Size(62, 20);
            this.player2NameLbl.TabIndex = 2;
            this.player2NameLbl.Text = "Player 2:";
            // 
            // player1NameLbl
            // 
            this.player1NameLbl.AutoSize = true;
            this.player1NameLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1NameLbl.Location = new System.Drawing.Point(250, 191);
            this.player1NameLbl.Name = "player1NameLbl";
            this.player1NameLbl.Size = new System.Drawing.Size(62, 20);
            this.player1NameLbl.TabIndex = 1;
            this.player1NameLbl.Text = "Player 1:";
            // 
            // enterNamesLbl
            // 
            this.enterNamesLbl.AutoSize = true;
            this.enterNamesLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNamesLbl.Location = new System.Drawing.Point(286, 155);
            this.enterNamesLbl.Name = "enterNamesLbl";
            this.enterNamesLbl.Size = new System.Drawing.Size(169, 23);
            this.enterNamesLbl.TabIndex = 0;
            this.enterNamesLbl.Text = "Enter the player names";
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(699, 402);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(89, 36);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Main Menu";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // player1SBLbl
            // 
            this.player1SBLbl.AutoSize = true;
            this.player1SBLbl.Location = new System.Drawing.Point(105, 89);
            this.player1SBLbl.Name = "player1SBLbl";
            this.player1SBLbl.Size = new System.Drawing.Size(108, 13);
            this.player1SBLbl.TabIndex = 2;
            this.player1SBLbl.Text = "Player 1\'s scoreboard";
            // 
            // player2SBLbl
            // 
            this.player2SBLbl.AutoSize = true;
            this.player2SBLbl.Location = new System.Drawing.Point(514, 89);
            this.player2SBLbl.Name = "player2SBLbl";
            this.player2SBLbl.Size = new System.Drawing.Size(108, 13);
            this.player2SBLbl.TabIndex = 3;
            this.player2SBLbl.Text = "Player 2\'s scoreboard";
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gamePnl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.player2SBLbl);
            this.Controls.Add(this.player1SBLbl);
            this.Name = "game";
            this.Text = "Bowling";
            this.Load += new System.EventHandler(this.game_Load);
            this.gamePnl.ResumeLayout(false);
            this.gamePnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gamePnl;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.TextBox player2NameTxt;
        private System.Windows.Forms.TextBox player1NameTxt;
        private System.Windows.Forms.Label player2NameLbl;
        private System.Windows.Forms.Label player1NameLbl;
        private System.Windows.Forms.Label enterNamesLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label player1SBLbl;
        private System.Windows.Forms.Label player2SBLbl;
    }
}