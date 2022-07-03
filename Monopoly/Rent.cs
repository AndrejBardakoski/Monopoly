using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    // abstract class representing the rent
    public abstract class Rent
    {
        public int Land { get; set; } //rent only land / one utility /one airline
        public Rent(int land)
        {
            Land = land;
        }
        public abstract int getRent(int state);
    }
}
