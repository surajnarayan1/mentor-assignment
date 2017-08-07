using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow
{
   public class Screen
    {

        public int Id { get; set; }
        public List <Seat> SeatAvailability { get; set; }
        public List<Movie> PlayingMovies { get; set; }
        public List<TimeSlot> ShowsSlotDaily { get; set; }
        public Icategory Type { get; set; }
        public Screen(int Id,List<Seat> SeatList,List<Movie> Movies,List<TimeSlot> Timeslot,Icategory Type)
        {
            this.Id = Id;
            this.PlayingMovies = Movies;
            this.SeatAvailability = SeatList;
            this.ShowsSlotDaily = Timeslot;
            this.Type = Type;
        }


    }
}
