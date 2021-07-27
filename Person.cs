using System;
using System.Collections.Generic;
using System.Text;

namespace YouTube
{
   public class Person
    {
        //string _MiddleName = "Royalty";
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get 
            {
                return FirstName + " " + LastName;
            }
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

    }
}
