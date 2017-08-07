using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow
{
    public class TheaterManager
    {
        public List<Theatre> theaters;
        public void AddNewTheater(Theatre theater)
        {
            theaters.Add(theater);
        }

        public TheaterManager()
        {
            theaters = new List<Theatre>();
        }

        
    }
}
