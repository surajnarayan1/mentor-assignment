using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow
{
    public class Theatre
    {
        public string Name { get; set; }
        public Address Location { get; set; }
        public string Rating { get; set; }
        public List<Screen> Screens { get; set; }
    }
}
