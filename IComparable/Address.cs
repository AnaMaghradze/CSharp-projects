using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// For namespaces, I've used the same names
/// </summary>
namespace AddressInfo
{
    /// <summary>
    /// In this class I've added explicit-value constructor, implemented CompareTo() method, so that it 
    /// compares LastNames, FirstNames and then Zip codes, also overrided ToString() method to display 
    /// data in the given format
    /// </summary>
    public class Address : IComparable<Address>
    {
        /// <summary>
        /// auto-implemented property for FirstName
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// auto-implemented property for LastName
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// auto-implemented property for AddressLineOne
        /// </summary>
        public string AddressLineOne { get; set; }
        /// <summary>
        /// auto-implemented property for AddressLineTwo
        /// </summary>
        public string AddressLineTwo { get; set; }
        /// <summary>
        /// auto-implemented property for City
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Handling negative numbers for Zip code
        /// </summary>
        private int zip;  // instance variable
        // property to get and set instance variable - zip
        public int Zip
        {
            get
            {
                return zip;
            }
            // if value is negative, won't be assigned to zip variable
            set
            {
                if (value > 0)
                {
                    zip = value;
                }
            }
        }
        /// <summary>
        /// auto-implemented property for State
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// auto-implemented property for BirthDay
        /// </summary>
        public DateTime BirthDay { get; set; }
        /// <summary>
        /// auto-implemented property for PhoneNumber
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// default constructor
        /// </summary>
        public Address() { }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="addressLineOne"></param>
        /// <param name="addressLineTwo"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zip"></param>
        /// <param name="birthDay"></param>
        /// <param name="phoneNumber"></param>
        public Address(string firstName, string lastName, string addressLineOne, string addressLineTwo,
                        string city, string state, int zip, DateTime birthDay, string phoneNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AddressLineOne = addressLineOne;
            this.AddressLineTwo = addressLineTwo;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.BirthDay = birthDay;
            this.PhoneNumber = phoneNumber;
        }
        /// <summary>
        /// this method compares LastNames, then FirstNames, then Zip Codes
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Address other)
        {
            // if LastNames are different, compare them
            if (String.Compare(LastName, other.LastName) != 0)
            {
                return String.Compare(LastName, other.LastName);
            }
            // if LastNames are the same, compare FirstNames
            else if (String.Compare(FirstName, other.FirstName) != 0)
            {
                return String.Compare(FirstName, other.FirstName);
            }
            // if FirsNames are the same, compare zip codes
            else
            {
                return Zip - other.Zip;   // in ascending order
            }
        }
        /// <summary>
        /// overriding ToString() method to display data
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "FirstName, LastName:  " + this.FirstName + " " + this.LastName
                    + "\nBuilding Name:        " + this.AddressLineOne
                    + "\nStreet Address:       " + this.AddressLineTwo
                    + "\nCity, State, Zip:     " + this.City + ", " + this.State + ", " + this.Zip
                    + "\nPhone Number:         " + this.PhoneNumber + "\n____________________\n";
        }
        /// <summary>
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        /// <summary>
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
