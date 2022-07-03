using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public abstract class Scene
    {
        public abstract void Click(Point point);
        public abstract void Draw(Graphics g);
    }
}
