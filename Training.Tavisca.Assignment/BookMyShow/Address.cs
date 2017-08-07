using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow
{
    public class Address
    {
        private string _city;
        private string _pinCode;
        private string _state;
        private string _country;




        public Address(string city, string pin, string state, string country)
        {
            _city = city;
            _pinCode = pin;
            _state = state;
            _country = country;
        }
        public string City { get; private set; }
        public string PinCode { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
    }
}
