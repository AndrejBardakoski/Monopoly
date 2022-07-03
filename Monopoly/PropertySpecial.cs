using Monopoly.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    // Class reperesenting a Special property Airline or Utility
    public class PropertySpecial : PropertyTile
    {
        public int Type { get; set; } // 0->Airline 1->Utility
        public PropertySpecial(String name, int location, int value, string shortName, RentAirline rent)
            : base(name, location, value, shortName)
        {
            Type = 0;
            Rent = rent;
        }
        public PropertySpecial(String name, int location, int value, string shortName, RentUtility rent)
            : base(name, location, value, shortName)
        {
            Type = 1;
            Rent = rent;
        }
        public override void Draw(Graphics g)
        {
            Point locationPoint = GetPointLocation(location);
            Pen pen = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(GetColor());
            if ((location / 10) % 2 == 0)
            {
                g.FillRectangle(brush, locationPoint.X, locationPoint.Y, UnitSize, 2 * UnitSize);
                g.DrawRectangle(pen, locationPoint.X, locationPoint.Y, UnitSize, 2 * UnitSize);
            }
            else
            {
                g.FillRectangle(brush, locationPoint.X, locationPoint.Y, 2 * UnitSize, UnitSize);
                g.DrawRectangle(pen, locationPoint.X, locationPoint.Y, 2 * UnitSize, UnitSize);
            }
            Image icon;
            if (Type == 0) { icon = Resources.AirplaneIcon; }
            else
            {
                if (location > 20) { icon = Resources.waterIcon; }
                else { icon = Resources.electrycityIcon; }
            }
            g.DrawImageUnscaled(icon, locationPoint.X + 5, locationPoint.Y + 5);
            if (Selected)
            {
                DrawSelected(g);
            }
            if (Owner != null)
            {
                DrawOwnerIcons(g);
            }
            if (State == -1) { DrawMortgage(g); }
            brush.Dispose();
            pen.Dispose();
        }
        public override string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            if (Type == 0)
            {
                RentAirline rent = Rent as RentAirline;
                sb.Append("Rent:\n");
                sb.Append("One Airline:    ").Append(rent.Land).AppendLine();
                sb.Append("Two Airlines:   ").Append(rent.TwoAirlines).AppendLine();
                sb.Append("Three Airlines: ").Append(rent.ThreeAirlines).AppendLine();
                sb.Append("Four Airlines:  ").Append(rent.FourAirlines).AppendLine();
            }
            else
            {
                RentUtility rent = Rent as RentUtility;
                sb.Append("Rent:\n");
                sb.Append("One Utility:    ").Append(rent.Land).AppendLine();
                sb.Append("Two Utilities:  ").Append(rent.TwoUtilities).AppendLine();
            }
            return sb.ToString();
        }
        public override Color GetColor()
        {
            return Color.FromArgb(255, 255, 135);
        }
        public override string GetStatusString()
        {
            if (State == 0) { return "ForSale"; }
            else if (State == -1) { return "Mortgaged"; }
            if (Type == 0)
            {
                if (State == 1) { return "One AirLine"; }
                else if (State == 2) { return "Two Airlines"; }
                else if (State == 3) { return "Three Airlines"; }
                else if (State == 4) { return "Four Airlines"; }
                return "";
            }
            if (State == 1) { return "One Utility"; }
            else if (State == 2) { return "Two Utilities"; }
            return "";
        }
    }
}
