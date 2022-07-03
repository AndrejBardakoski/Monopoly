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
    // Class reperesenting a PropertyCity
    public class PropertyCity : PropertyTile
    {
        public int HousePrice { get; set; }
        public int HotelPrice { get; set; }
        public int Group { get; set; }

        public PropertyCity(String name, int location, int value, string shortName,
            RentCity rent, int housePrice, int hotelPrice, int group)
            : base(name, location, value, shortName)
        {
            Rent = rent;
            HousePrice = housePrice;
            HotelPrice = hotelPrice;
            Group = group;
        }
        //cities from same group have same color
        public override Color GetColor()
        {
            if (Group == 1) { return Color.FromArgb(217, 0, 255); }
            else if (Group == 2) { return Color.FromArgb(22, 245, 226); ; }
            else if (Group == 3) { return Color.HotPink; }
            else if (Group == 4) { return Color.FromArgb(210, 210, 0); }
            else if (Group == 5) { return Color.DarkOrange; }
            else if (Group == 6) { return Color.FromArgb(240, 40, 40); }
            else if (Group == 7) { return Color.LawnGreen; }
            else { return Color.DarkGray; }
        }
        public override void Draw(Graphics g)
        {
            Point locationPoint = GetPointLocation(location);
            Pen pen = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(GetColor());
            Brush whiteBrush = new SolidBrush(Color.White);
            if ((location / 10) % 2 == 0)
            {
                g.FillRectangle(brush, locationPoint.X, locationPoint.Y, UnitSize, 2 * UnitSize);
                g.DrawRectangle(pen, locationPoint.X, locationPoint.Y, UnitSize, 2 * UnitSize);
                g.FillRectangle(whiteBrush, locationPoint.X + 5, locationPoint.Y + 5, 45, 25);
                Font font = new Font("Courier New", 16, FontStyle.Bold);
                g.DrawString(ShortName, font, brush, locationPoint.X + 5, locationPoint.Y + 5);
            }
            else
            {
                g.FillRectangle(brush, locationPoint.X, locationPoint.Y, 2 * UnitSize, UnitSize);
                g.DrawRectangle(pen, locationPoint.X, locationPoint.Y, 2 * UnitSize, UnitSize);
                g.FillRectangle(whiteBrush, locationPoint.X + 5, locationPoint.Y + 15, 45, 25);
                Font font = new Font("Courier New", 16, FontStyle.Bold);
                g.DrawString(ShortName, font, brush, locationPoint.X + 5, locationPoint.Y + 15);
            }
            if (Selected)
            {
                DrawSelected(g);
            }
            if (Owner != null)
            {
                DrawOwnerIcons(g);
            }
            if (State > 1) { DrawHouses(g); }
            if (State == -1) { DrawMortgage(g); }
            whiteBrush.Dispose();
            brush.Dispose();
            pen.Dispose();
        }
        private void DrawHouses(Graphics g)
        {
            Point locationPoint = GetPointLocation(location);
            Image img = null;
            if (State == 2) { img = Resources.House1; }
            else if (State == 3) { img = Resources.House2; }
            else if (State == 4) { img = Resources.House3; }
            else if (State == 5) { img = Resources.House4; }
            else if (State == 6) { img = Resources.Hotel; }
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
        //Get info for InfoBox Form
        public override string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            RentCity rent = Rent as RentCity;
            sb.Append("Rent:\n");
            sb.Append("Only land:    ").Append(rent.Land).AppendLine();
            sb.Append("One House:    ").Append(rent.House1).AppendLine();
            sb.Append("Two Houses:   ").Append(rent.House2).AppendLine();
            sb.Append("Three Houses: ").Append(rent.House3).AppendLine();
            sb.Append("Four Houses:  ").Append(rent.House4).AppendLine();
            sb.Append("Hotel:        ").Append(rent.Hotel).AppendLine();
            sb.AppendLine();
            sb.Append("House price:  ").Append(HousePrice).AppendLine();
            sb.Append("Hotel price:  ").Append(HotelPrice).AppendLine();

            return sb.ToString();
        }
        public override string GetStatusString()
        {
            if (State == 0) { return "ForSale"; }
            else if (State == 1) { return "Only Land"; }
            else if (State == 2) { return "One House"; }
            else if (State == 3) { return "Two Houses"; }
            else if (State == 4) { return "Three Houses"; }
            else if (State == 5) { return "Four Houses"; }
            else if (State == 6) { return "Hotel"; }
            else if (State == -1) { return "Mortgaged"; }
            return "";
        }
    }
}
