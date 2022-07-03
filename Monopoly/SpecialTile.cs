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
    //class representing a special tile on the board (not a property) 

    public class SpecialTile : Tile
    {
        public int Type { get; set; } // 0->Start 1-> Jail 2->Parking 3->GoToJail 4->chance/suprice 5->Bingo 6->Taxes

        public SpecialTile(String name, int location, int type) : base(name, location)
        {
            Type = type;
        }

        public override void StepOnTile(Player player)
        {
            if (Type == 0) { return; } //start do nothing
            string msg = "";
            if (Type == 3) // go to jail
            {
                player.Location = 10; // jail_Location 
            }
            if (Type == 1 || Type == 3) //jail
            {
                player.InJail = true;
                player.SkipedTurns = 3; // skiped_Turns_Jail
                msg = "GO IN JAIl!";
            }
            else if (Type == 2) //parking
            {
                player.SkipedTurns = 1; // skiped turns pause
                msg = player.Name + " must pause 1 turn";
            }
            else if (Type == 4) //suprice/chance
            {
                msg = StepOnSuprice(player);
                if (msg == null)
                {
                    return;
                }
            }
            else if (Type == 5) //Bingo
            {
                player.Balance += 50000;
                msg = "Congratulation, " + player.Name + " won Bingo amount recived: 50000$";
            }
            else if (Type == 6) //Tax
            {
                player.Balance -= 25000;
                msg = player.Name + " must pay taxes. Taxes cost: 25000$";
            }
            MessageBox.Show(msg);
        }
        private string StepOnSuprice(Player player)
        {
            RNG rand = RNG.getRNG();
            int option = rand.nextInt(0, 10);
            int amount = 1;
            if (option < 6) //60% recive or lose money
            {
                int randInt = rand.nextInt(0, 100);
                if (randInt < 50) //50% recive/lose <25000$
                {
                    amount *= rand.nextInt(1, 5);
                    amount *= 5000;
                }
                else if (randInt < 80) //30% recive/lose between (25000$-40000$)
                {
                    amount *= rand.nextInt(1, 4);
                    amount *= 5000;
                    amount += 20000;
                }
                else if (randInt < 95) //15% recive/lose between (45000$-70000$)
                {
                    amount *= rand.nextInt(1, 6);
                    amount *= 5000;
                    amount += 40000;
                }
                else //5% recive/lose between (75000$-100000$)
                {
                    amount *= rand.nextInt(0, 5);
                    amount *= 5000;
                    amount += 75000;
                }
            }
            if (option < 3) //30% recive money
            {
                player.Balance += amount;
                return "Congratulation, " + player.Name + " won " + amount + "$";
            }
            else if (option < 6) //30% lose money
            {
                player.Balance -= (int)(amount * 0.75); //lose 75% of the amount
                return "Sorry, " + player.Name + " lost " + amount / 2 + "$";
            }
            else if (option == 6) //10% move (1-6) tiles forward
            {
                int randInt = rand.nextInt(1, 6);
                string msg = "Move " + randInt + " tiles forward";
                MessageBox.Show(msg);
                player.Location += randInt;
                if (player.Location >= 40) //Start passes
                {
                    player.Location %= 40;
                    player.Balance += 20000;
                }
                SceneMain.getTile(player.Location).StepOnTile(player);
                return null; // message already showed
            }
            else if (option == 7)// 10% move(1 - 6) tiles backward
            {
                int randInt = rand.nextInt(1, 6);
                string msg = "Move " + randInt + " tiles backward";
                MessageBox.Show(msg);
                player.Location -= randInt;
                player.Location += player.Location < 0 ? 40 : 0; //Start passes
                SceneMain.getTile(player.Location).StepOnTile(player);
                return null; // message already showed
            }
            else if (option == 8)// 10% pause (1-3) turns
            {
                int randInt = rand.nextInt(0, 6);
                int pausedTruns;
                if (randInt < 3) { pausedTruns = 1; } // 50% pause 1 turn 
                else if (randInt < 5) { pausedTruns = 2; }// 33% pause 2 turns
                else { pausedTruns = 3; } //17% pause 3 turns
                player.SkipedTurns += pausedTruns;
                return player.Name + " must pause " + pausedTruns + " turns";
            }
            else if (option == 9)// 10% RollAgain
            {
                player.RollAgain = true;
                return player.Name + " can roll again ";
            }
            return null;
        }
        public override void Draw(Graphics g)
        {
            Point locationPoint = GetPointLocation(location);
            Pen pen = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(Color.FromArgb(237, 252, 243));
            if (Type <= 3) // corner size (2 X 2 unitSize)
            {
                g.FillRectangle(brush, locationPoint.X, locationPoint.Y, 2 * UnitSize, 2 * UnitSize);
                g.DrawRectangle(pen, locationPoint.X, locationPoint.Y, 2 * UnitSize, 2 * UnitSize);
            }
            else if ((location / 10) % 2 == 0) // Top/Bottom Row size (1 X 2 unitSize)
            {
                g.FillRectangle(brush, locationPoint.X, locationPoint.Y, UnitSize, 2 * UnitSize);
                g.DrawRectangle(pen, locationPoint.X, locationPoint.Y, UnitSize, 2 * UnitSize);
            }
            else // Top / Bottom Row size(2 X 1 unitSize)
            {
                g.FillRectangle(brush, locationPoint.X, locationPoint.Y, 2 * UnitSize, UnitSize);
                g.DrawRectangle(pen, locationPoint.X, locationPoint.Y, 2 * UnitSize, UnitSize);
            }
            Image icon;
            int offsetX = 5, offsetY = 5;
            if (Type == 0) { icon = Resources.startIcon; }
            else if (Type == 1) { icon = Resources.jail_icon; }
            else if (Type == 2) { icon = Resources.parkingIcon; }
            else if (Type == 3) { icon = Resources.goToJailIcon; }
            else if (Type == 4)
            {
                if (Name.StartsWith("C")) { icon = Resources.chanceIcon; }
                else { icon = Resources.supriceIcon; }
            }
            else if (Type == 5)
            {
                icon = Resources.bingoIcno;
            }
            else { icon = Resources.taxIcon; }
            g.DrawImageUnscaled(icon, locationPoint.X + offsetX, locationPoint.Y + offsetY);
            brush.Dispose();
            pen.Dispose();
        }
        public override string GetInfo() //get info for InfoBox Form
        {
            StringBuilder sb = new StringBuilder();
            if (Type == 0)
            {
                sb.Append("Starting tile").AppendLine();
                sb.Append("Each time a player crosses start").AppendLine();
                sb.Append("recives 20000$").AppendLine();
            }
            else if (Type == 1)
            {
                sb.Append("A player is in jail, it can't recive rents").AppendLine();
                sb.Append("A player can exit jail if:").AppendLine();
                sb.Append("pay 50000$").AppendLine();
                sb.Append("or skip 3 turns").AppendLine();
            }
            else if (Type == 2)
            {
                sb.Append("A player on parking skip one turn\n");
            }
            else if (Type == 3)
            {
                sb.Append("the player sreping this tile\n").AppendLine();
                sb.Append("goes directly to jail\n").AppendLine();
                sb.Append("without crossing the start\n").AppendLine();
            }
            else if (Type == 4)
            {
                sb.Append("Recive or lose Random amount of money\n");
            }
            else if (Type == 5)
            {
                sb.Append("Bingo the player recives 50000$\n");
            }
            else if (Type == 6)
            {
                sb.Append("the player must pay 25000$ for taxes\n");
            }
            return sb.ToString();
        }
        public override bool Click(Point point)
        {
            Point locationPoint = GetPointLocation(location);
            Rectangle rectangle;
            if (Type <= 3) //corner tile
            {
                rectangle = new Rectangle(locationPoint.X, locationPoint.Y, 2 * UnitSize, 2 * UnitSize);
                return rectangle.Contains(point);
            }
            else
            {
                return base.Click(point);
            }
        }
    }
}
