using Monopoly.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    // class representing the main scene
    public class SceneMain : Scene
    {
        public static List<Tile> Map { get; set; } = new List<Tile>();
        public List<Player> Players { get; set; } = new List<Player>();
        public int activPlayerIndex = 0;
        public static int OffsetX = 30;
        public static int OffsetY = 30;
        public int Dice1 = 5;
        public int Dice2 = -1;
        public int DiceSpecial = -1;
        public bool MoveStopFlag = true;
        public bool CanEndTurn = false;
        public bool CanDeclareBankruptcy = false;
        public int ClickMode = 0; // 0->Info 1->Build 2->sell 3->Mortgage 4->Redeem
        public SceneMain()
        {
            GenetateMap();
        }
        public SceneMain(List<Player> players, int dice)
        {
            this.Players = players;
            GenetateMap();
            Dice1 = 5;
            if (dice > 1) { Dice2 = 3; }
            if (dice > 2) { DiceSpecial = 1; }
        }
        private void GenetateMap()
        {
            Map.Add(new SpecialTile("Start", 0, 0));
            Map.Add(new PropertyCity("Ottawa", 1, 30000, "OTW", new RentCity(20000, 30000, 40000, 50000, 60000, 100000), 20000, 30000, 1));
            Map.Add(new SpecialTile("Bingo", 2, 5));
            Map.Add(new PropertyCity("New York", 3, 50000, "NYC", new RentCity(30000, 50000, 70000, 90000, 110000, 160000), 30000, 70000, 1));
            Map.Add(new SpecialTile("Chance", 4, 4));
            Map.Add(new PropertySpecial("Qatar Airways", 5, 50000, "QTR", new RentAirline(10000, 30000, 50000, 70000)));
            Map.Add(new PropertyCity("Moscow", 6, 50000, "MSC", new RentCity(30000, 40000, 60000, 80000, 100000, 150000), 25000, 50000, 2));
            Map.Add(new SpecialTile("Suprise", 7, 4));
            Map.Add(new PropertyCity("London", 8, 40000, "LND", new RentCity(25000, 35000, 45000, 65000, 80000, 110000), 25000, 40000, 2));
            Map.Add(new PropertyCity("Paris", 9, 45000, "PRS", new RentCity(25000, 40000, 60000, 80000, 100000, 140000), 25000, 50000, 2));
            Map.Add(new SpecialTile("Jail", 10, 1));
            Map.Add(new PropertyCity("Ljubljana", 11, 35000, "LJB", new RentCity(15000, 25000, 40000, 55000, 70000, 100000), 20000, 40000, 3));
            Map.Add(new PropertySpecial("Electric utility", 12, 40000, "ELC", new RentUtility(20000, 50000)));
            Map.Add(new PropertyCity("Zagreb", 13, 30000, "ZBG", new RentCity(10000, 20000, 30000, 45000, 65000, 90000), 15000, 35000, 3));
            Map.Add(new PropertyCity("Tirana", 14, 25000, "TRN", new RentCity(10000, 20000, 30000, 40000, 70000, 90000), 15000, 30000, 3));
            Map.Add(new PropertySpecial("Qantas Airways", 15, 50000, "QNT", new RentAirline(10000, 30000, 50000, 70000)));
            Map.Add(new PropertyCity("Athens", 16, 35000, "ATH", new RentCity(20000, 35000, 45000, 60000, 85000, 120000), 20000, 45000, 4));
            Map.Add(new SpecialTile("Chance", 17, 4));
            Map.Add(new PropertyCity("Rome", 18, 45000, "ROM", new RentCity(20000, 40000, 65000, 80000, 100000, 130000), 30000, 50000, 4));
            Map.Add(new PropertyCity("Cairo", 19, 30000, "CAR", new RentCity(15000, 25000, 40000, 50000, 60000, 90000), 15000, 35000, 4));
            Map.Add(new SpecialTile("Parking", 20, 2));
            Map.Add(new PropertyCity("Bangkok", 21, 40000, "BNG", new RentCity(25000, 35000, 45000, 60000, 75000, 110000), 20000, 40000, 5));
            Map.Add(new SpecialTile("Suprise", 22, 4));
            Map.Add(new PropertyCity("Manila", 23, 30000, "MNL", new RentCity(15000, 25000, 40000, 60000, 75000, 90000), 20000, 35000, 5));
            Map.Add(new PropertyCity("Jakarta", 24, 25000, "JKR", new RentCity(15000, 25000, 40000, 50000, 60000, 90000), 20000, 30000, 5));
            Map.Add(new PropertySpecial("Japan Airlines", 25, 50000, "JPN", new RentAirline(10000, 30000, 50000, 70000)));
            Map.Add(new PropertyCity("Tokyo", 26, 45000, "TKY", new RentCity(30000, 45000, 60000, 75000, 90000, 130000), 25000, 55000, 6));
            Map.Add(new PropertyCity("Beijing", 27, 35000, "BJG", new RentCity(20000, 35000, 45000, 60000, 80000, 105000), 20000, 45000, 6));
            Map.Add(new PropertySpecial("Water utility", 28, 40000, "WTR", new RentUtility(20000, 50000)));
            Map.Add(new PropertyCity("Seul", 29, 35000, "SUL", new RentCity(25000, 40000, 50000, 70000, 90000, 120000), 25000, 40000, 6));
            Map.Add(new SpecialTile("Go To Jail", 30, 3));
            Map.Add(new PropertyCity("Las Vegas", 31, 50000, "LVG", new RentCity(20000, 35000, 50000, 70000, 110000, 160000), 20000, 50000, 7));
            Map.Add(new PropertyCity("Havana", 32, 40000, "HVN", new RentCity(20000, 30000, 45000, 60000, 80000, 100000), 20000, 40000, 7));
            Map.Add(new SpecialTile("Chance", 33, 4));
            Map.Add(new PropertyCity("Buenos Aires", 34, 30000, "BNA", new RentCity(15000, 30000, 45000, 60000, 75000, 95000), 15000, 30000, 7));
            Map.Add(new PropertySpecial("Air France", 35, 50000, "AFR", new RentAirline(10000, 30000, 50000, 70000)));
            Map.Add(new SpecialTile("Suprise", 36, 4));
            Map.Add(new PropertyCity("Skopje", 37, 30000, "SKP", new RentCity(10000, 20000, 35000, 45000, 60000, 80000), 10000, 25000, 8));
            Map.Add(new SpecialTile("Tax", 38, 6));
            Map.Add(new PropertyCity("Belgrade", 39, 40000, "BGR", new RentCity(15000, 25000, 40000, 50000, 65000, 90000), 15000, 30000, 8));
        }
        public static Tile getTile(int Location)
        {
            return Map[Location];
        }
        // table box player click
        public void tbPlayerClick(int index)
        {
            InfoBox infoBox = new InfoBox(Players[index]);
            infoBox.ShowDialog();
        }
        // clcikMode 0-> show info box; 1-> build; 2->sell; 3->Mortage; 4->Redeem
        public override void Click(Point point)
        {
            if (ClickMode == 0) { ClickInfoMode(point); }
            else
            {
                Player player = GetActivePlayer();
                foreach (Tile tile in Map)
                {
                    if (tile is PropertyTile)
                    {
                        PropertyTile propertyTile = (PropertyTile)tile;
                        if (propertyTile.Selected && propertyTile.Click(point))
                        {
                            if (ClickMode == 1) { player.Build(propertyTile as PropertyCity); Build(); }
                            else if (ClickMode == 2) { player.Sell(propertyTile as PropertyCity); Sell(); }
                            else if (ClickMode == 3) { player.Mortgage(propertyTile); Mortgage(); }
                            else if (ClickMode == 4) { player.Redeem(propertyTile); Redeem(); }
                        }
                    }
                }
            }
        }
        private void ClickInfoMode(Point point)
        {
            foreach (Tile tile in Map)
            {
                if (tile is PropertyTile)
                {
                    PropertyTile propertyTile = (PropertyTile)tile;
                    if (propertyTile.Click(point))
                    {
                        InfoBox infoBox = new InfoBox(propertyTile);
                        infoBox.ShowDialog();
                    }
                }
                else if (tile is SpecialTile)
                {
                    SpecialTile specialTile = (SpecialTile)tile;
                    if (specialTile.Click(point))
                    {
                        InfoBox infoBox = new InfoBox(specialTile);
                        infoBox.ShowDialog();
                    }
                }

            }
        }
        public override void Draw(Graphics g)
        {
            Image board = Resources.BoardInner;
            g.DrawImageUnscaled(board, Tile.UnitSize * 2 + OffsetX, Tile.UnitSize * 2 + OffsetY);
            Pen pen = new Pen(Color.Black, 5);
            g.DrawRectangle(pen, OffsetX, OffsetY, Tile.UnitSize * 13, Tile.UnitSize * 13);
            pen.Dispose();
            foreach (Tile tile in Map)
            {
                tile.Draw(g);
            }
            foreach (Player player in Players)
            {
                player.Draw(g);
                g.DrawImageUnscaled(player.Icon, 1000, 40 + player.PlayerID * 45);
            }
            Player active = GetActivePlayer();
            Pen penActive = new Pen(Color.FromArgb(114, 13, 191), 6);
            g.DrawEllipse(penActive, 1000, 40 + active.PlayerID * 45, 45, 45);
            g.DrawRectangle(penActive, 751, 46 + 45 * activPlayerIndex, 244, 36);
            penActive.Dispose();
            if (Dice2 == -1 && DiceSpecial == -1) //one dice
            {
                g.DrawImageUnscaled(getDiceImage(Dice1, false), 870, 250);
            }
            else if (DiceSpecial == -1)// two dice
            {
                g.DrawImageUnscaled(getDiceImage(Dice1, false), 810, 250);
                g.DrawImageUnscaled(getDiceImage(Dice2, false), 920, 250);
            }
            else //three dice
            {
                g.DrawImageUnscaled(getDiceImage(Dice1, false), 770, 250);
                g.DrawImageUnscaled(getDiceImage(DiceSpecial, true), 870, 250);
                g.DrawImageUnscaled(getDiceImage(Dice2, false), 970, 250);
            }
        }
        // return image of the face of dice with input number
        // special-> return image of special dice
        private Image getDiceImage(int number, bool special)
        {
            if (special)
            {
                if (number == 1) { return Resources.SpecialDiceStop; }
                else if (number == 2) { return Resources.SpecialDiceRoll; }
                else if (number == 3) { return Resources.SpecialDiceMultiply; }
                else if (number == 4) { return Resources.SpecialDiceMin; }
                else if (number == 5) { return Resources.SpecialDiceSuprice; }
                else if (number == 6) { return Resources.SpecialDiceNext; }
            }
            else
            {
                if (number == 1) { return Resources.Dice1; }
                else if (number == 2) { return Resources.Dice2; }
                else if (number == 3) { return Resources.Dice3; }
                else if (number == 4) { return Resources.Dice4; }
                else if (number == 5) { return Resources.Dice5; }
                else if (number == 6) { return Resources.Dice6; }
            }
            return null;
        }
        public Player GetActivePlayer()
        {
            return Players[activPlayerIndex];
        }
        // move 1 tile forward
        public void Move()
        {
            Player player = GetActivePlayer();
            player.Move();
        }
        // return if player should stop move (reached its destination)
        public bool ShouldStopMove()
        {
            Player player = GetActivePlayer();
            return player.Location == player.NextLocation;
        }
        public void SetNextLocation(Nullable<int> loc = null)
        {
            if (loc == null) { loc = CalcDiceMove(); }
            Player player = GetActivePlayer();
            player.NextLocation = player.Location + (int)loc;
            player.NextLocation %= Map.Count;
        }
        public void DiceRoll()
        {
            RNG rNG = RNG.getRNG();
            Dice1 = rNG.DiceRoll();
            if (Dice2 != -1) { Dice2 = rNG.DiceRoll(); }
            if (DiceSpecial != -1) { DiceSpecial = rNG.DiceRoll(); }
        }
        public int CalcDiceMove()
        {
            if ((Dice2 == -1 && DiceSpecial == -1)) { return Dice1; } // one dice
            else if (DiceSpecial == -1) { return Dice2 + Dice1; } // two dice
            else
            {
                if (DiceSpecial == 1) { return 0; } // end turn
                else if (DiceSpecial == 2) { return Dice2 + Dice1; }
                else if (DiceSpecial == 3) { return Dice2 * Dice1; }// multiply dice
                else if (DiceSpecial == 4) { return Math.Min(Dice1, Dice2); } // min dice
                else if (DiceSpecial == 5) { return Dice2 + Dice1; }
                else { return Dice2 + Dice1; }
            }
        }
        public int StopMove()
        {
            Player player = GetActivePlayer();
            player.NextLocation = -1;
            if (DiceSpecial == 1) { SetCanEndTurn(); return 1; }//end move
            player.RollAgain = false;
            Map[player.Location].StepOnTile(player);
            if (player.SkipedTurns > 0) { SetCanEndTurn(); return 1; } //player steped on jail or parking,must pause
            else if (DiceSpecial == 5) { Map[4].StepOnTile(player); }//diceSpecial->suprice (same as step on suprice tile)

            if (player.SkipedTurns > 0) { SetCanEndTurn(); return 1; } //check again if player must pause
            else if (DiceSpecial == 2 || player.RollAgain) { return 2; } //player can rollAgain
            else if (DiceSpecial == 6 && MoveStopFlag) //DiceSpecial -> move to next not owned property
            {
                MoveStopFlag = false;
                player.NextLocation = LocationNextProperty();
                if (player.NextLocation != -1) { return 6; }
            }
            if (Dice1 == Dice2) { return 2; }//player can rollAgain
            SetCanEndTurn();
            return 0;
        }
        public void SetCanEndTurn()
        {
            CanEndTurn = true;
            UpdateCanDeclareBankruptcy();
        }
        public void UpdateCanDeclareBankruptcy()
        {
            Player player = GetActivePlayer();
            if (player.Balance >= 0) { CanDeclareBankruptcy = false; }
            else { CanDeclareBankruptcy = true; }
        }
        public bool DeclareBankruptcy() // return true if GameOver
        {
            CanDeclareBankruptcy = false;
            Player player = GetActivePlayer();
            player.DeclareBankruptcy();
            EndTurn();
            int count = 0;
            foreach (Player plyr in Players)
            {
                if (!plyr.Bankrupt) { count++; }
            }
            if (count < 2)
            {
                return true;
            }
            return false;
        }
        public int LocationNextProperty()
        {
            Player player = GetActivePlayer();
            int currentLocation = player.Location;
            for (int i = 1; i < Map.Count; i++)
            {
                int j = currentLocation + i;
                j %= Map.Count;
                if (Map[j] is PropertyTile)
                {
                    PropertyTile property = Map[j] as PropertyTile;
                    if (property.Owner == null)
                    {
                        return j;
                    }
                }
            }
            return -1;
        }
        public void EndTurn()
        {
            activPlayerIndex++;
            activPlayerIndex %= Players.Count;
            Player player = GetActivePlayer();
            if (player.Bankrupt) { EndTurn(); }
            if (player.InJail && player.SkipedTurns == 0) { player.InJail = false; } //get out of jail
            if (player.InJail && player.Balance >= 50000)
            {
                DialogResult dialogResult;
                if (player.IsCPU)
                {
                    if (player.Balance >= 125000) { dialogResult = DialogResult.Yes; }
                    else { dialogResult = DialogResult.No; }
                }
                else
                {
                    dialogResult = MessageBox.Show("Pay 50000$ to get out of jail?",
                       "Get out of jail", MessageBoxButtons.YesNo);
                }
                if (dialogResult == DialogResult.Yes)
                {
                    player.Balance -= 50000;
                    player.InJail = false;
                    player.SkipedTurns = 0;
                }
            }
            if (player.SkipedTurns > 0)
            {
                player.SkipedTurns--;
                EndTurn();
            }
        }
        //return true if activePlayer isCPU
        public bool IsCPU()
        {
            Player player = GetActivePlayer();
            return player.IsCPU;
        }
        // function that makes a CPU player decide his actions (redeeming , building, trading)
        public void ActionCPU()
        {
            Player player = GetActivePlayer();
            player.SelectCanRedeem();
            if (player.Balance >= 75000 && PropertySelected())
            {
                player.Redeem(GetFirstSelected());
                DeselectProperties();
                ActionCPU();
                return;
            }
            DeselectProperties();
            player.SelectCanBuild();
            if (player.Balance >= 135000 && PropertySelected())
            {
                player.Build(GetFirstSelected() as PropertyCity);
                DeselectProperties();
                ActionCPU();
                return;
            }
            DeselectProperties();
            if (player.TradeCPU(Map))
            {
                ActionCPU();
                return;
            }
        }
        // recursive function that makes a CPU player try to avoid bankruptcy (selling , mortgagin)
        public bool BankruptcyCPU() //return true if Bankruptcy can't be avoided
        {
            UpdateCanDeclareBankruptcy();
            Player player = GetActivePlayer();
            if (!CanDeclareBankruptcy) { return false; }
            player.SelectCanSell();
            if (PropertySelected())
            {
                player.Sell(GetFirstSelected() as PropertyCity);
                DeselectProperties();
                return BankruptcyCPU();
            }
            player.SelectCanMortgage();
            if (PropertySelected())
            {
                player.Mortgage(GetFirstSelected());
                DeselectProperties();
                return BankruptcyCPU();
            }
            return true;
        }
        // btnBuildClick    enter build mode 
        public bool Build()
        {
            Player player = GetActivePlayer();
            player.SelectCanBuild();
            ClickMode = 1;
            return PropertySelected();
        }
        // btnSellClick      enter sell mode 
        public bool Sell()
        {
            Player player = GetActivePlayer();
            player.SelectCanSell();
            ClickMode = 2;
            return PropertySelected();
        }
        // btnMortgageClick  enter mortgage mode 
        public bool Mortgage()
        {
            Player player = GetActivePlayer();
            player.SelectCanMortgage();
            ClickMode = 3;
            return PropertySelected();
        }
        // btnRedeemClick   enter redeem mode 
        public bool Redeem()
        {
            Player player = GetActivePlayer();
            player.SelectCanRedeem();
            ClickMode = 4;
            return PropertySelected();
        }
        public bool PropertySelected()
        {
            foreach (Tile tile in Map)
            {
                if (tile is PropertyTile)
                {
                    if ((tile as PropertyTile).Selected) { return true; }
                }
            }
            return false;
        }
        public PropertyTile GetFirstSelected()
        {
            Player player = GetActivePlayer();
            return player.GetFirstSelected();
        }
        // btnTradeClick
        public void Trade()
        {
            Player playerOffering = GetActivePlayer();
            List<Player> playersList = new List<Player>();
            for (int i = 0; i < Players.Count; i++)
            {
                if (!Players[i].Bankrupt && activPlayerIndex != i)
                {
                    playersList.Add(Players[i]);
                }
            }
            TradeForm tradeForm = new TradeForm(playerOffering, playersList);
            if (tradeForm.ShowDialog() == DialogResult.OK)
            {
                Player playerOffered = tradeForm.PlayerOffered;
                DialogResult result;
                if (playerOffered.IsCPU)
                {
                    if (playerOffered.TradeDecision(tradeForm))
                    {
                        result = DialogResult.Yes;
                        MessageBox.Show(playerOffered.Name + " Accepted " + playerOffering.Name
                            + "'s Offer", "Offer Accepted");
                    }
                    else
                    {
                        result = DialogResult.No;
                        MessageBox.Show(playerOffered.Name + " Declined " + playerOffering.Name
                            + "'s Offer", "Offer Declined");
                    }
                }
                else
                {
                    TradeOfferForm tradeOfferForm = new TradeOfferForm(tradeForm);
                    result = tradeOfferForm.ShowDialog();
                }
                if (result == DialogResult.Yes)
                {
                    playerOffering.Trade(tradeForm);
                }
            }
            UpdateCanDeclareBankruptcy();
        }
        //btnDoneClick      enter default mode (info mode)
        public void DoneClick()
        {
            Player player = GetActivePlayer();
            ClickMode = 0;
            UpdateCanDeclareBankruptcy();
            DeselectProperties();
        }
        public void DeselectProperties()
        {
            foreach (Tile tile in Map)
            {
                if (tile is PropertyTile)
                {
                    (tile as PropertyTile).Selected = false;
                }
            }
        }
    }
}
