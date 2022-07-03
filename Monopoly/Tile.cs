using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    // abstract class representing a tile on the board(Map)
    // (SpecialTile,PropertyTile(PropertyCity,PropertySpecial)) classes that inherit Tile
    public abstract class Tile
    {
        //Information usefull for drawing the tile and the board
        public static int UnitSize = 55;
        public string Name { get; set; }
        public int location { get; set; } // 0-39 
        public Tile(string name, int location)
        {
            Name = name;
            this.location = location;
        }
        public abstract void StepOnTile(Player player);
        public abstract void Draw(Graphics g);
        public abstract string GetInfo();
        // returning an actual location on the screen
        public static Point GetPointLocation(int location)
        {
            int offsetX = SceneMain.OffsetX;
            int offsetY = SceneMain.OffsetY;
            int cordX, cordY;
            if (location <= 10) //Top row
            {
                cordY = 0;
                if (location == 0) { cordX = 0; }
                else
                {
                    cordX = UnitSize + location * UnitSize;
                }
            }
            else if (location <= 20) //Right Column
            {
                cordX = UnitSize * 11;
                if (location == 20) { cordY = UnitSize * 11; }
                else
                {
                    cordY = UnitSize + (location % 10) * UnitSize;
                }
            }
            else if (location <= 30) //Bottom row
            {
                cordY = UnitSize * 11;
                if (location == 30) { cordX = 0; }
                else
                {
                    cordX = UnitSize * 11 - (location % 10) * UnitSize;
                }
            }
            else // left column
            {
                cordX = 0;
                cordY = UnitSize * 11 - (location % 10) * UnitSize;
            }
            return new Point(cordX + offsetX, cordY + offsetY);
        }
        //Overrided in Special tile to work on corner tiles
        public virtual bool Click(Point point)
        {
            Point locationPoint = GetPointLocation(location);
            Rectangle rectangle;
            if ((location / 10) % 2 == 0) // top and bottom row
            {
                rectangle = new Rectangle(locationPoint.X, locationPoint.Y, UnitSize, 2 * UnitSize);
            }
            else //left and right column
            {
                rectangle = new Rectangle(locationPoint.X, locationPoint.Y, UnitSize * 2, UnitSize);
            }
            return rectangle.Contains(point);
        }
    }
}
