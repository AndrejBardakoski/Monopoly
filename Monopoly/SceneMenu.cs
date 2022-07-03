using Monopoly.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class SceneMenu : Scene
    {
        public override void Click(Point point) { }
        public override void Draw(Graphics g)
        {
            Image header = Resources.MonopolyText;
            g.DrawImageUnscaled(header, 5, 15);
        }
    }
}
