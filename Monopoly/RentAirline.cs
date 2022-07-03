using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    // lass representing the rent for Airlines
    public class RentAirline : Rent
    {
        public int TwoAirlines { get; set; }
        public int ThreeAirlines { get; set; }
        public int FourAirlines { get; set; }
        public RentAirline(int oneAirpot, int twoAirports, int threeAirports, int fourAirports) : base(oneAirpot)
        {
            TwoAirlines = twoAirports;
            ThreeAirlines = threeAirports;
            FourAirlines = fourAirports;
        }
        public override int getRent(int state)
        {
            if (state <= 0) return 0;
            if (state == 1) return Land;
            if (state == 2) return TwoAirlines;
            if (state == 3) return ThreeAirlines;
            if (state == 4) return FourAirlines;
            else throw new Exception();
        }
    }
}
