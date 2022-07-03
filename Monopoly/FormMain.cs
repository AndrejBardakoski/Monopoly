using Monopoly.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    // the main form
    public partial class FormMain : Form
    {
        Scene scene;
        SceneMain mainScene;
        FormInitGame formGame;
        int timerTick = 0;
        bool CanDiceRoll = true;  //flag representing if btnDiceRoll can be enabled
        public FormMain()
        {
            InitializeComponent();
            DoubleBuffered = true;
            scene = new SceneMenu();
            InitMainMenu();
        }
        private void InitMainMenu()
        {
            scene = new SceneMenu();
            DisableGame();
            this.BackColor = Color.FromArgb(247, 133, 62);
            this.Height = 610;
            this.Width = 525;

            btnNewGame.Visible = true;
            btnNewGame.Image = Resources.Button;
            btnNewGame.Width = 450;
            btnNewGame.Height = 100;
            btnNewGame.Location = new Point(40, 140);

            btnHowToPlay.Visible = true;
            btnHowToPlay.Image = Resources.Button;
            btnHowToPlay.Width = 450;
            btnHowToPlay.Height = 100;
            btnHowToPlay.Location = new Point(40, 290);

            btnExit.Visible = true;
            btnExit.Image = Resources.Button;
            btnExit.Width = 450;
            btnExit.Height = 100;
            btnExit.Location = new Point(40, 440);
            Invalidate();
        }
        private void disableMainMenu()
        {
            btnNewGame.Visible = false;
            btnHowToPlay.Visible = false;
            btnExit.Visible = false;
        }
        private void DisableGame()
        {
            mainScene = null;
            tbPlayer1.Visible = false;
            tbPlayer2.Visible = false;
            tbPlayer3.Visible = false;
            tbPlayer4.Visible = false;
            tbActionDetails.Visible = false;
            btnBankrupt.Visible = false;
            btnDone.Visible = false;
            SetVisibleButtons(false);
        }
        private void InitGame()
        {
            disableMainMenu();
            this.Height = 800;
            this.Width = 1100;

            CanDiceRoll = true;
            timerTick = 0;

            this.BackColor = Color.FromArgb(255, 200, 166);

            scene = new SceneMain(formGame.players, formGame.numDice);
            mainScene = (scene as SceneMain);
            List<Player> players = mainScene.Players;
            tbPlayer1.Location = new Point(755, 50);
            tbPlayer2.Location = new Point(755, 95);
            tbPlayer3.Location = new Point(755, 140);
            tbPlayer4.Location = new Point(755, 185);
            tbPlayer1.Visible = true;
            tbPlayer2.Visible = true;
            if (players.Count > 3) { tbPlayer4.Visible = true; }
            if (players.Count > 2) { tbPlayer3.Visible = true; }
            if (players.Count < 2) { throw new Exception(); }
            UpdateTbText();
            EnableButtons();
            SetVisibleButtons(true);
            tbActionDetails.BackColor = this.BackColor;
            tbActionDetails.Location = new Point(770, 350);
            tbActionDetails.Size = new Size(270, 255);
            btnDiceRoll.Location = new Point(850, 350);
            btnDiceRoll.Size = new Size(120, 45);
            btnEndTurn.Location = new Point(850, 640);
            btnEndTurn.Size = new Size(120, 45);
            btnBankrupt.Enabled = true;
            btnBankrupt.Location = new Point(850, 700);
            btnBankrupt.Size = new Size(120, 45);
            btnBuild.Location = new Point(770, 425);
            btnBuild.Size = new Size(120, 45);
            btnSell.Location = new Point(910, 425);
            btnSell.Size = new Size(120, 45);
            btnMortgage.Location = new Point(770, 500);
            btnMortgage.Size = new Size(120, 45);
            btnRedeem.Location = new Point(910, 500);
            btnRedeem.Size = new Size(120, 45);
            btnTrade.Location = new Point(850, 575);
            btnTrade.Size = new Size(120, 45);
            btnDone.Location = new Point(850, 630);
            btnDone.Size = new Size(120, 45);
            Invalidate();
        }
        private void UpdateTbText()
        {
            List<Player> players = mainScene.Players;
            tbPlayer1.Text = String.Format("{0,-10} {1,7}$", players[0].Name, players[0].Balance.ToString());
            tbPlayer1.BackColor = players[0].color;
            tbPlayer2.Text = String.Format("{0,-10} {1,7}$", players[1].Name, players[1].Balance.ToString());
            tbPlayer2.BackColor = players[1].color;
            if (players[0].Bankrupt) { tbPlayer1.Enabled = false; }
            if (players[1].Bankrupt) { tbPlayer2.Enabled = false; }
            if (players.Count > 2)
            {
                tbPlayer3.Text = String.Format("{0,-10} {1,7}$", players[2].Name,
                    players[2].Balance.ToString());
                tbPlayer3.BackColor = players[2].color;
                if (players[2].Bankrupt) { tbPlayer3.Enabled = false; }
            }
            if (players.Count > 3)
            {
                tbPlayer4.Text = String.Format("{0,-10} {1,7}$", players[3].Name,
                    players[3].Balance.ToString());
                tbPlayer4.BackColor = players[3].color;
                if (players[3].Bankrupt) { tbPlayer4.Enabled = false; }
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (scene is SceneMain) { UpdateTbText(); }
            scene.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scene.Click(new Point(e.X, e.Y));
            Invalidate();
        }
        private void tbPlayer1_MouseClick(object sender, MouseEventArgs e)
        {
            mainScene.tbPlayerClick(0);
        }
        private void tbPlayer2_MouseClick(object sender, MouseEventArgs e)
        {
            mainScene.tbPlayerClick(1);
        }
        private void tbPlayer3_MouseClick(object sender, MouseEventArgs e)
        {
            mainScene.tbPlayerClick(2);
        }
        private void tbPlayer4_MouseClick(object sender, MouseEventArgs e)
        {
            mainScene.tbPlayerClick(3);
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).Image = Resources.ButtonHover;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).Image = Resources.Button;
        }
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            (sender as Button).Image = Resources.ButtonClick;
            formGame = new FormInitGame();
            if (formGame.ShowDialog() == DialogResult.OK)
            {
                InitGame();
            }
        }
        private void btnExit_MouseClick(object sender, MouseEventArgs e)
        {
            btnExit.Image = Resources.ButtonClick;
            this.Close();
        }
        private void btnContinue_MouseClick(object sender, MouseEventArgs e)
        {
            btnHowToPlay.Image = Resources.ButtonClick;
            HowToPlayForm howToPlayForm = new HowToPlayForm();
            howToPlayForm.ShowDialog();
        }
        private void timerDiceRoll_Tick(object sender, EventArgs e)
        {
            timerTick++;
            if (timerTick <= 15) { mainScene.DiceRoll(); }
            else if (timerTick == 16) { mainScene.SetNextLocation(); }
            else if (timerTick > 20 && timerTick % 2 == 0) { MovePlayer(); }
            Invalidate();
        }
        private void btnDiceRoll_Click(object sender, EventArgs e)
        {
            CanDiceRoll = false;
            btnDiceRoll.Enabled = false;
            mainScene.MoveStopFlag = true;
            timerTick = 0;
            timerDiceRoll.Start();
        }
        private void MovePlayer()
        {
            if (mainScene.ShouldStopMove())
            {
                timerDiceRoll.Stop();
                Invalidate();
                int action = mainScene.StopMove();
                UpdateTbText();
                if (action == 2)
                {
                    if (mainScene.IsCPU())
                    {
                        btnDiceRoll_Click(null, null);
                        Invalidate();
                        return;
                    }
                    else { CanDiceRoll = true; }
                }
                else if (action == 6)
                {
                    timerTick = 22;
                    timerDiceRoll.Start();
                    //test
                    return;
                }
                btnDiceRoll.Enabled = CanDiceRoll;
                if (mainScene.IsCPU() && mainScene.CanDeclareBankruptcy)
                {
                    if (mainScene.BankruptcyCPU()) { btnBankrupt_Click(null, null); return; }
                }
                else
                {
                    btnBankrupt.Visible = mainScene.CanDeclareBankruptcy;
                }
                if (mainScene.IsCPU() && mainScene.CanEndTurn
                    && !mainScene.CanDeclareBankruptcy)
                { btnEndTurn_Click(null, null); }
                else
                {
                    btnEndTurn.Enabled = mainScene.CanEndTurn
                        && !mainScene.CanDeclareBankruptcy;
                }
            }
            else { mainScene.Move(); }
            Invalidate();
        }
        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            mainScene.CanEndTurn = false;
            btnEndTurn.Enabled = false;
            mainScene.EndTurn();
            if (mainScene.IsCPU())
            {
                DisableButtons();
                mainScene.ActionCPU();
                btnDiceRoll_Click(null, null);
            }
            else
            {
                CanDiceRoll = true;
                EnableButtons();
                btnEndTurn.Enabled = false;
            }
            Invalidate();
        }
        private void btnBankrupt_Click(object sender, EventArgs e)
        {
            btnBankrupt.Visible = false;
            if (mainScene.DeclareBankruptcy())
            {
                Player player = mainScene.GetActivePlayer();
                GameOverForm gameOverform = new GameOverForm(player.Name);
                gameOverform.ShowDialog();
                DisableGame();
                InitMainMenu();
            }
            else
            {
                if (mainScene.IsCPU())
                {
                    DisableButtons();
                    mainScene.ActionCPU();
                    btnDiceRoll_Click(null, null);
                    return;
                }
                CanDiceRoll = true;
                btnDiceRoll.Enabled = true;
            }
        }
        private void EnableButtons()
        {
            btnDiceRoll.Enabled = CanDiceRoll;
            btnEndTurn.Enabled = mainScene.CanEndTurn
                && !mainScene.CanDeclareBankruptcy;
            btnBuild.Enabled = true;
            btnSell.Enabled = true;
            btnMortgage.Enabled = true;
            btnRedeem.Enabled = true;
            btnTrade.Enabled = true;
        }
        private void DisableButtons()
        {
            btnDiceRoll.Enabled = false;
            btnEndTurn.Enabled = false;
            btnBuild.Enabled = false;
            btnSell.Enabled = false;
            btnMortgage.Enabled = false;
            btnRedeem.Enabled = false;
            btnTrade.Enabled = false;
        }
        private void SetVisibleButtons(bool visible)
        {
            btnDiceRoll.Visible = visible;
            btnEndTurn.Visible = visible;
            btnBuild.Visible = visible;
            btnSell.Visible = visible;
            btnMortgage.Visible = visible;
            btnRedeem.Visible = visible;
            btnTrade.Visible = visible;
            if (visible) { btnBankrupt.Visible = mainScene.CanDeclareBankruptcy; }
            else { btnBankrupt.Visible = visible; }
        }
        private void btnMortgage_Click(object sender, EventArgs e)
        {
            SetVisibleButtons(false);
            btnDone.Visible = true;
            StringBuilder sb = new StringBuilder();
            if (mainScene.Mortgage())
            {
                sb.Append("Click on a property you own to mortgage it!").AppendLine().AppendLine();
                sb.Append("If you want to mortgage a property that has hauses you must sell the houses first!");
                sb.AppendLine().AppendLine();
                sb.Append("Mortgaging a property gives you half the value price.").AppendLine();
            }
            else
            {
                sb.Append("You don't own a property that can be mortgaged!").AppendLine().AppendLine();
                sb.Append("If you want to mortgage a property that has hauses you must sell the houses first!").AppendLine();
            }
            tbActionDetails.Text = sb.ToString();
            tbActionDetails.Visible = true;
            Invalidate();
        }
        private void btnRedeem_Click(object sender, EventArgs e)
        {
            SetVisibleButtons(false);
            btnDone.Visible = true;
            StringBuilder sb = new StringBuilder();
            if (mainScene.Redeem())
            {
                sb.Append("Click on a mortgaged property you own to redeem it!").AppendLine().AppendLine();
                sb.Append("Redeeming a property cost halft the value price + 5000$").AppendLine();
            }
            else
            {
                sb.Append("You don't own a Mortgaged property to redeem!").AppendLine();
            }
            tbActionDetails.Text = sb.ToString();
            tbActionDetails.Visible = true;
            Invalidate();
        }
        private void btnTrade_Click(object sender, EventArgs e)
        {
            mainScene.Trade();
            EnableButtons();
            btnBankrupt.Visible = mainScene.CanDeclareBankruptcy;
            Invalidate();
        }
        private void btnBuild_Click(object sender, EventArgs e)
        {
            SetVisibleButtons(false);
            btnDone.Visible = true;
            StringBuilder sb = new StringBuilder();
            if (mainScene.Build())
            {
                sb.Append("Click on a property you own to build a house!").AppendLine().AppendLine();
                sb.Append("You must own all properties of the same color to be able to build houses!");
                sb.AppendLine().AppendLine();
                sb.Append("You must build houses equaly distributed!").AppendLine();
            }
            else
            {
                sb.Append("You don't own a property where house can be build!").AppendLine().AppendLine();
                sb.Append("You must own all properties of the same color to be able to build houses!");
            }
            tbActionDetails.Text = sb.ToString();
            tbActionDetails.Visible = true;
            Invalidate();
        }
        private void btnSell_Click(object sender, EventArgs e)
        {
            SetVisibleButtons(false);
            btnDone.Visible = true;
            StringBuilder sb = new StringBuilder();
            if (mainScene.Sell())
            {
                sb.Append("Click on a property you own to sell a house!").AppendLine().AppendLine();
                sb.Append("You recive only half the price of the house!").AppendLine().AppendLine();
                sb.Append("You must sell houses equaly distributed!").AppendLine();
            }
            else
            {
                sb.Append("You don't own houses to sell!").AppendLine();
            }
            tbActionDetails.Text = sb.ToString();
            tbActionDetails.Visible = true;
            Invalidate();
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            SetVisibleButtons(true);
            tbActionDetails.Visible = false;
            btnDone.Visible = false;
            mainScene.DoneClick();
            btnBankrupt.Visible = mainScene.CanDeclareBankruptcy;
            btnEndTurn.Enabled = mainScene.CanEndTurn
                && !mainScene.CanDeclareBankruptcy;
            Invalidate();
        }
    }
}
