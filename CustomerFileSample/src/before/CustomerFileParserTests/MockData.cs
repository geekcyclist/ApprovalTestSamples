using System;
using System.Collections.Generic;
using System.Text;
using CustomerFileParser.Models;

namespace CustomerFileParserTests
{
    public static class MockData
    {
        public static Customer CreateHomer()
        {
            return new Customer
            {
                Id = 1,
                FirstName = "Homer",
                LastName = "Simpson",
                Street = "742 Evergreen Terrace",
                City = "Springfield",
                State = "IL",
                Zip = "62704",
                Zip4 = "7023",
                Age = 39
            };
        }

        public static Customer CreateMarge()
        {
            return new Customer
            {
                Id = 2,
                FirstName = "Marge",
                LastName = "Simpson",
                Street = "742 Evergreen Terrace",
                City = "Springfield",
                State = "IL",
                Zip = "62704",
                Zip4 = "7023",
                Age = 39
            };
        }

        public static IEnumerable<Customer> CreateCustomerList()
        {
            var customers = new List<Customer> {CreateHomer(), CreateMarge()};
            return customers;
        }

        public const string SampleRows =
            @"1256897   Robert              Alan                Johnson             Jr      7843 Bunker Hill Dr                     Sandy               UT87074132447 
1256898   Sylvia              Jean                Anderson                    1821 W 6720 S Apt 7                     West Jordan         UT84084    31 
1256899   Jennifer                                Carlysle                    1571 Chablis Cir                        Sandy               UT84092280152 
1256900   Jeremiah            James               Searle                      3167 S Patrick Dr                       Magna               UT84044320139 
1256901   Ian                 Patrick             O'Brian             III     229 University Village                  Salt Lake City      UT84108    24  ";

    }
}
