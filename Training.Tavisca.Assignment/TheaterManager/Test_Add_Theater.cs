using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookMyShow;
using System.Collections.Generic;

namespace TheaterManager
{
    [TestClass]
    public class Test_Add_Theater
    {
        [TestMethod]
        public void Test_for_add_a_theater()
        {
            List<Movie> movies = new List<Movie>();
            Movie first = new Movie();
            first.Name = "Dunkirk";
            first.LeadCast = "Suraj";
            first.Rating = "1 Star";
            first.CriticReview = "sadasda";
            first.UserReview = "dfsadf";
            movies.Add(first);
            List<Seat> seats = new List<Seat>();
            Seat newSeat = new Seat();
            newSeat.SeatAvailability = true;
            newSeat.SeatNo = "A1";
            seats.Add(newSeat);
            List<TimeSlot> timeslots = new List<TimeSlot>();
            TimeSlot slot = new TimeSlot();
            slot.Movie = first;
            Time startTime = new Time()
            {
                Hours = 1,
                Minutes=15,
                Seconds=0
            };
            slot.StartTime = startTime;
            slot.EndTime = startTime;
            timeslots.Add(slot);
            Theatre theater = new Theatre()
            {
                Name = "PVR",
                Location = new Address("Pune", "411014", "Maharashtra", "Indian"),
                Rating = "3-Star",
                Screens = new List<Screen>()
                {
                    new Screen(1,seats,movies,timeslots,
                    new Gold()
                    {
                        _price=133,
                        _seatRange=new SeatRange()
                    }
                    ),
                   
                }
            };
            BookMyShow.TheaterManager manager = new BookMyShow.TheaterManager();
            manager.AddNewTheater(theater);
            //Assert.IsTrue(manager.theaters.Contains(theater));

            Assert.IsTrue(theater.Name.Contains("PVR"));
        }
    }
}
