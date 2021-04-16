using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Ana Magrhadze 
/// 823356346
/// </summary>
namespace AddressInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Address A1 = new Address();
            // list of people and their addresses
            List<Address> addresList = new List<Address>()
            {
                new Address("Anna", "Maghradze", "#1", "Melrose Avenue", "Los Angeles",
                            "California", 90001,new DateTime(2001, 6, 6), "111-111"),
                new Address("Nino", "Maghradze", "#2", "178th Ave", "Miami",
                            "Florida", 33124, new DateTime(2000, 10, 4), "222-222"),
                new Address("George", "Arevadze", "#3", "12th", "Atlanta",
                            "Georgia", 30301, new DateTime(2002, 5, 11), "333-333"),
                new Address("Anna", "Maghradze", "#4", "15th", "Dover",
                            "Delevare", 19901, new DateTime(2000, 2, 7), "444-444"),
                new Address("David", "Gvasalia", "#5", "16th Street Mall", "Denver",
                            "Colorado", 80201, new DateTime(2001, 8, 10), "555-555")
            };
            // sort data in the list by LastName, FirstName, and Zip code
            addresList.Sort();
            // display each person and address information from the addressList
            foreach (var person in addresList)
            {
                Console.WriteLine(person);
            }
        }
    }
}