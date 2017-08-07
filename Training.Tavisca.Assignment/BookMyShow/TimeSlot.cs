using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow
{
    public class TimeSlot
    {
        public Time StartTime { get; set; }
        public Time EndTime { get; set; }
        public Movie Movie { get; set; }
    }
}
