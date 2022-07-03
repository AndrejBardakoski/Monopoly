namespace Monopoly
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.tbPlayer1 = new System.Windows.Forms.TextBox();
            this.tbPlayer2 = new System.Windows.Forms.TextBox();
            this.tbPlayer3 = new System.Windows.Forms.TextBox();
            this.tbPlayer4 = new System.Windows.Forms.TextBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnHowToPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.timerDiceRoll = new System.Windows.Forms.Timer(this.components);
            this.btnDiceRoll = new System.Windows.Forms.Button();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.btnBankrupt = new System.Windows.Forms.Button();
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnMortgage = new System.Windows.Forms.Button();
            this.btnTrade = new System.Windows.Forms.Button();
            this.btnRedeem = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.tbActionDetails = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbPlayer1
            // 
            this.tbPlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbPlayer1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbPlayer1.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlayer1.ForeColor = System.Drawing.Color.Black;
            this.tbPlayer1.Location = new System.Drawing.Point(383, 38);
            this.tbPlayer1.Name = "tbPlayer1";
            this.tbPlayer1.ReadOnly = true;
            this.tbPlayer1.Size = new System.Drawing.Size(314, 36);
            this.tbPlayer1.TabIndex = 0;
            this.tbPlayer1.TabStop = false;
            this.tbPlayer1.Text = "Name1 200000$ ";
            this.tbPlayer1.Visible = false;
            this.tbPlayer1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbPlayer1_MouseClick);
            // 
            // tbPlayer2
            // 
            this.tbPlayer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbPlayer2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbPlayer2.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlayer2.ForeColor = System.Drawing.Color.Black;
            this.tbPlayer2.Location = new System.Drawing.Point(383, 78);
            this.tbPlayer2.Name = "tbPlayer2";
            this.tbPlayer2.ReadOnly = true;
            this.tbPlayer2.Size = new System.Drawing.Size(314, 36);
            this.tbPlayer2.TabIndex = 2;
            this.tbPlayer2.TabStop = false;
            this.tbPlayer2.Text = "Name1 200000$ ";
            this.tbPlayer2.Visible = false;
            this.tbPlayer2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbPlayer2_MouseClick);
            // 
            // tbPlayer3
            // 
            this.tbPlayer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbPlayer3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbPlayer3.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlayer3.Location = new System.Drawing.Point(383, 122);
            this.tbPlayer3.Name = "tbPlayer3";
            this.tbPlayer3.ReadOnly = true;
            this.tbPlayer3.Size = new System.Drawing.Size(314, 36);
            this.tbPlayer3.TabIndex = 3;
            this.tbPlayer3.TabStop = false;
            this.tbPlayer3.Text = "Name1 200000$ ";
            this.tbPlayer3.Visible = false;
            this.tbPlayer3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbPlayer3_MouseClick);
            // 
            // tbPlayer4
            // 
            this.tbPlayer4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbPlayer4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbPlayer4.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlayer4.Location = new System.Drawing.Point(383, 164);
            this.tbPlayer4.Name = "tbPlayer4";
            this.tbPlayer4.ReadOnly = true;
            this.tbPlayer4.Size = new System.Drawing.Size(314, 36);
            this.tbPlayer4.TabIndex = 4;
            this.tbPlayer4.TabStop = false;
            this.tbPlayer4.Text = "Name1 200000$ ";
            this.tbPlayer4.Visible = false;
            this.tbPlayer4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbPlayer4_MouseClick);
            // 
            // btnNewGame
            // 
            this.btnNewGame.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnNewGame.FlatAppearance.BorderSize = 0;
            this.btnNewGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.White;
            this.btnNewGame.Location = new System.Drawing.Point(12, 12);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(225, 75);
            this.btnNewGame.TabIndex = 5;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            this.btnNewGame.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.btnNewGame.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // btnHowToPlay
            // 
            this.btnHowToPlay.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnHowToPlay.FlatAppearance.BorderSize = 0;
            this.btnHowToPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHowToPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnHowToPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHowToPlay.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHowToPlay.ForeColor = System.Drawing.Color.White;
            this.btnHowToPlay.Location = new System.Drawing.Point(12, 89);
            this.btnHowToPlay.Name = "btnHowToPlay";
            this.btnHowToPlay.Size = new System.Drawing.Size(225, 75);
            this.btnHowToPlay.TabIndex = 6;
            this.btnHowToPlay.Text = "How to play";
            this.btnHowToPlay.UseVisualStyleBackColor = true;
            this.btnHowToPlay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnContinue_MouseClick);
            this.btnHowToPlay.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.btnHowToPlay.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(22, 170);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(225, 75);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnExit_MouseClick);
            this.btnExit.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // timerDiceRoll
            // 
            this.timerDiceRoll.Tick += new System.EventHandler(this.timerDiceRoll_Tick);
            // 
            // btnDiceRoll
            // 
            this.btnDiceRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnDiceRoll.Location = new System.Drawing.Point(-7, -2);
            this.btnDiceRoll.Name = "btnDiceRoll";
            this.btnDiceRoll.Size = new System.Drawing.Size(75, 23);
            this.btnDiceRoll.TabIndex = 8;
            this.btnDiceRoll.TabStop = false;
            this.btnDiceRoll.Text = "Dice Roll";
            this.btnDiceRoll.UseVisualStyleBackColor = true;
            this.btnDiceRoll.Click += new System.EventHandler(this.btnDiceRoll_Click);
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnEndTurn.Location = new System.Drawing.Point(-7, 27);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(75, 23);
            this.btnEndTurn.TabIndex = 9;
            this.btnEndTurn.TabStop = false;
            this.btnEndTurn.Text = "EndTurn";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // btnBankrupt
            // 
            this.btnBankrupt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnBankrupt.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnBankrupt.FlatAppearance.BorderSize = 2;
            this.btnBankrupt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankrupt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnBankrupt.ForeColor = System.Drawing.Color.White;
            this.btnBankrupt.Location = new System.Drawing.Point(-7, 60);
            this.btnBankrupt.Name = "btnBankrupt";
            this.btnBankrupt.Size = new System.Drawing.Size(75, 23);
            this.btnBankrupt.TabIndex = 10;
            this.btnBankrupt.TabStop = false;
            this.btnBankrupt.Text = "Bankrupt";
            this.btnBankrupt.UseVisualStyleBackColor = false;
            this.btnBankrupt.Click += new System.EventHandler(this.btnBankrupt_Click);
            // 
            // btnBuild
            // 
            this.btnBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuild.Location = new System.Drawing.Point(-7, 93);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(75, 23);
            this.btnBuild.TabIndex = 11;
            this.btnBuild.TabStop = false;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // btnSell
            // 
            this.btnSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.Location = new System.Drawing.Point(-7, 130);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 23);
            this.btnSell.TabIndex = 12;
            this.btnSell.TabStop = false;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnMortgage
            // 
            this.btnMortgage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMortgage.Location = new System.Drawing.Point(-7, 164);
            this.btnMortgage.Name = "btnMortgage";
            this.btnMortgage.Size = new System.Drawing.Size(75, 23);
            this.btnMortgage.TabIndex = 13;
            this.btnMortgage.TabStop = false;
            this.btnMortgage.Text = "Mortgage";
            this.btnMortgage.UseVisualStyleBackColor = true;
            this.btnMortgage.Click += new System.EventHandler(this.btnMortgage_Click);
            // 
            // btnTrade
            // 
            this.btnTrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrade.Location = new System.Drawing.Point(-7, 193);
            this.btnTrade.Name = "btnTrade";
            this.btnTrade.Size = new System.Drawing.Size(75, 23);
            this.btnTrade.TabIndex = 14;
            this.btnTrade.TabStop = false;
            this.btnTrade.Text = "Trade";
            this.btnTrade.UseVisualStyleBackColor = true;
            this.btnTrade.Click += new System.EventHandler(this.btnTrade_Click);
            // 
            // btnRedeem
            // 
            this.btnRedeem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedeem.Location = new System.Drawing.Point(-7, 222);
            this.btnRedeem.Name = "btnRedeem";
            this.btnRedeem.Size = new System.Drawing.Size(75, 23);
            this.btnRedeem.TabIndex = 15;
            this.btnRedeem.TabStop = false;
            this.btnRedeem.Text = "Redeem";
            this.btnRedeem.UseVisualStyleBackColor = true;
            this.btnRedeem.Click += new System.EventHandler(this.btnRedeem_Click);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnDone.Location = new System.Drawing.Point(-7, 251);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 16;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // tbActionDetails
            // 
            this.tbActionDetails.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbActionDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.tbActionDetails.Location = new System.Drawing.Point(-7, 280);
            this.tbActionDetails.Multiline = true;
            this.tbActionDetails.Name = "tbActionDetails";
            this.tbActionDetails.ReadOnly = true;
            this.tbActionDetails.Size = new System.Drawing.Size(100, 22);
            this.tbActionDetails.TabIndex = 17;
            this.tbActionDetails.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(133)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(758, 330);
            this.Controls.Add(this.tbActionDetails);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnRedeem);
            this.Controls.Add(this.btnTrade);
            this.Controls.Add(this.btnMortgage);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.btnBankrupt);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.btnDiceRoll);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHowToPlay);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.tbPlayer4);
            this.Controls.Add(this.tbPlayer3);
            this.Controls.Add(this.tbPlayer2);
            this.Controls.Add(this.tbPlayer1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPlayer1;
        private System.Windows.Forms.TextBox tbPlayer2;
        private System.Windows.Forms.TextBox tbPlayer3;
        private System.Windows.Forms.TextBox tbPlayer4;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnHowToPlay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timerDiceRoll;
        private System.Windows.Forms.Button btnDiceRoll;
        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.Button btnBankrupt;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnMortgage;
        private System.Windows.Forms.Button btnTrade;
        private System.Windows.Forms.Button btnRedeem;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox tbActionDetails;
    }
}

