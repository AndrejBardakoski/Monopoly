using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    // class representing the rent for City properties
    public class RentCity : Rent
    {
        public int House1 { get; set; }
        public int House2 { get; set; }
        public int House3 { get; set; }
        public int House4 { get; set; }
        public int Hotel { get; set; }
        public RentCity(int land, int house1, int house2, int house3, int house4, int hotel) : base(land)
        {
            House1 = house1;
            House2 = house2;
            House3 = house3;
            House4 = house4;
            Hotel = hotel;
        }
        public override int getRent(int state)
        {
            if (state <= 0) return 0;
            if (state == 1) return Land;
            if (state == 2) return House1;
            if (state == 3) return House2;
            if (state == 4) return House3;
            if (state == 5) return House4;
            if (state == 6) return Hotel;
            else throw new Exception();
        }
    }
}
