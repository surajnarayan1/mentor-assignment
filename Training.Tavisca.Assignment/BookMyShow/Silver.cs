using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow
{
    public class Silver : Icategory
    {
        double _price;
        SeatRange _seatRange;

        public double price()
        {
            return _price;
        }

        public SeatRange Range()
        {
            return _seatRange;
        }
    }
}
