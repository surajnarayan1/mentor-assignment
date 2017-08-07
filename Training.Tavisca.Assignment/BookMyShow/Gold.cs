using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow
{
    public class Gold : Icategory
    {
        public double _price { get; set; }
        public SeatRange _seatRange { get; set; }
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
