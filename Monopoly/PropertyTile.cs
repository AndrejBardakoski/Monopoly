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
    // abstract class representing a Property
    // (PropertyCity , PropertySpecial) classes that inherit PropertyTile
    public abstract class PropertyTile : Tile
    {
        public int Value { get; set; }
        public Rent Rent { get; set; }
        // -1->Mortgage; 0->not owned; 1->only land; 2->1house; 3->2houses; ... 6->Hotel;
        public int State { get; set; } = 0;
        public Player Owner { get; set; } = null;
        public string ShortName { get; set; } //3 lettered ID name
        public bool Selected = false;
        public PropertyTile(String name, int location, int value, string shortName) : base(name, location)
        {
            Value = value;
            ShortName = shortName;
        }
        public abstract Color GetColor();
        public override void StepOnTile(Player player)
        {
            if (State == 0) //not owned
            {
                player.BuyProperty(this);
            }
            else if (player == Owner) // do nothing
            {
                return;
            }
            else if (Owner.InJail) { return; }// do nothing
            else if (State > 0) //pay rent
            {
                player.Balance -= Rent.getRent(this.State);
                Owner.Balance += Rent.getRent(State);
                string msg = player.Name + " Paid: "
                    + Rent.getRent(State).ToString() + " rent to: " + Owner.Name;
                MessageBox.Show(msg);
            }
        }
        public abstract string GetStatusString();
        public void DrawOwnerIcons(Graphics g)
        {
            Point locationPoint = GetPointLocation(location);
            Image icon = Owner.IconSamll;
            if (location / 10 == 0)
            {
                g.DrawImageUnscaled(icon, locationPoint.X + 15, locationPoint.Y + UnitSize * 2 - 10);
            }
            else if (location / 10 == 2)
            {
                g.DrawImageUnscaled(icon, locationPoint.X + 15, locationPoint.Y - 15);
            }
            else if (location / 10 == 3)
            {
                g.DrawImageUnscaled(icon, locationPoint.X + UnitSize * 2 - 10, locationPoint.Y + 15);
            }
            else
            {
                g.DrawImageUnscaled(icon, locationPoint.X - 15, locationPoint.Y + 15);
            }
        }
        public void DrawSelected(Graphics g)
        {
            Point locationPoint = GetPointLocation(location);
            Pen pen = new Pen(Color.FromArgb(114, 13, 191), 6);
            if ((location / 10) % 2 == 0)
            {
                g.DrawRectangle(pen, locationPoint.X + 3, locationPoint.Y + 3, UnitSize - 6, 2 * UnitSize - 6);
            }
            else
            {
                g.DrawRectangle(pen, locationPoint.X + 3, locationPoint.Y + 3, 2 * UnitSize - 6, UnitSize - 6);
            }
            pen.Dispose();
        }
        public void DrawMortgage(Graphics g)
        {
            Point locationPoint = GetPointLocation(location);
            Image img = null;
            if (State == -1) { img = Resources.Mortgage; }
            if (img == null) { return; }
            if (location / 10 % 2 == 0)
            {
                g.DrawImageUnscaled(img, locationPoint.X + 5, locationPoint.Y + 60);
            }
            else
            {
                g.DrawImageUnscaled(img, locationPoint.X + 60, locationPoint.Y + 5);
            }
        }
        public override string ToString()
        {
            return String.Format("{0,-17}{1,7}$", Name + ":", Value);
        }
    }
}
