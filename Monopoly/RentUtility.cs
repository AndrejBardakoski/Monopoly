using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    // class representing the rent for Utilities
    public class RentUtility : Rent
    {
        public int TwoUtilities { get; set; }
        public RentUtility(int oneUtility, int twoUtilities) : base(oneUtility)
        {
            TwoUtilities = twoUtilities;
        }
        public override int getRent(int state)
        {
            if (state <= 0) return 0;
            if (state == 1) return Land;
            if (state == 2) return TwoUtilities;
            else throw new Exception();
        }
    }
}
