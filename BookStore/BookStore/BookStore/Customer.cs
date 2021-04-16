using System;
/// <summary>
/// Ana Maghradze
/// red ID: 823356346
/// </summary>
namespace BookStore
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int CustomerId { get; set; }

        public Customer(string first, string last, string email, string phone,
            string state, string city, string address, string zip, int id)
        {
            FirstName = first;
            LastName = last;
            Email = email;
            Phone = phone;
            State = state;
            City = city;
            Address = address;         
            Zip = zip;
            CustomerId = id;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
