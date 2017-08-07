using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow
{
    public class Name
    {

        //private string _firstname;
        //private string _middlename;
        //private string _lastName;

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        //public Address SetAddress(string firstname, string middlename, string lastName)
        //{
        //    return new Address
        //    { _firstname = firstname, _middlename= middlename,_lastName= lastName
        //};

        public Name(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;

            MiddleName = middleName;

            LastName = lastName;
        }


    }
}
