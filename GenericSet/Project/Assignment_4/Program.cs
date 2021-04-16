using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Ana Maghradze
/// 823356346
/// </summary>
namespace COMPE361
{
    class Program
    {
        // return even numbers
        public static bool FilterByEven(int a)
        {
            return a % 2 == 0;
        }
        // return objects starting with A
        public static bool FilterByLetterA(string a)
        {
            return a.StartsWith("A");
        }

        static void Main(string[] args)
        {
            // objects of Set class with type int 
            Set<int> set1 = new Set<int>() { 0, 2, 14, 6, 23, 16, 3, 1 };
            Set<int> set2 = new Set<int>() { 4, 3, 3, 10, 3, 6, 5, 2 };
            // obj of Set class with type string
            Set<string> set3 = new Set<string>() { "D", "B", "A", "M", "G" };
            // obj of SortedSet class with type int
            SortedSet<int> sorted1 = new SortedSet<int>() { 5, 7, 4, 8, 6, 9 };
            // obj of SortedSet class with type string
            SortedSet<string> sorted2 = new SortedSet<string>() { "Luka", "Khatia", "Nika", "Anna", "Giorgi" };

            // create objects of class Person
            Person p1 = new Person("Nini");
            Person p2 = new Person("Anna");
            Person p3 = new Person("Mariam");
            // object of Set class with type Person
            Set<Person> setOfP = new Set<Person>() { p1, p2, p3 };
            // object of SortedSet class with type Person
            SortedSet<Person> sortedSetOfP = new SortedSet<Person>() { p1, p2, p3 };
             
            // set0 - empty set
            Set<int> set0 = new Set<int>() { };
            set0.DisplaySet();
            // set1
            Console.WriteLine("\nset1");
            set1.DisplaySet(); // display set
            set1.Remove(12); // 12 is not in set so nothing will be removed
            set1.Remove(0); // 0 is removed from the set
            set1.DisplaySet(); // display modified set
            set1.Add(0); // add 0 to the set
            set1.DisplaySet(); // display modified set 
            int a = 3; // check if item is in set
            Console.WriteLine($"{a} Is In set: {set1.Contains(a)}");
            int b = 956; // check if item is in set
            Console.WriteLine($"{b} Is In set: {set1.Contains(b)}");
            // set2
            Console.WriteLine("\n\nset2");
            set2.DisplaySet();
            // union of non-sorted sets
            Console.WriteLine("\n\nUnion of set1, set2\n");
            Set<int> union = new Set<int>();
            union = set1 + set2; // union of set1 and set2               
            union.DisplaySet();
            // set3
            Console.WriteLine("\n\nset3");
            set3.DisplaySet();
            string item = "J"; // check if item is in set
            string item1 = "D"; // check if item is in set
            Console.WriteLine($"{item} Is In set: {set3.Contains(item)}");
            Console.WriteLine($"{item1} Is In set: {set3.Contains(item1)}");
            // sorted1
            Console.WriteLine("\n\nsorted1");
            sorted1.DisplaySet(); 
            sorted1.Remove(7); // remove 7 from sorted set
            sorted1.DisplaySet(); // display modified set
            sorted1.Add(25); // Add 25 to sorted set
            sorted1.Add(19); // Add 25 to sorted set
            sorted1.DisplaySet(); // display modified set

            // sorted3
            SortedSet<int> sorted3 = new SortedSet<int>() { 0, 18, 5, 56, 4, 26, 7 };
            Console.WriteLine("\n\nsorted3");
            sorted3.DisplaySet();
            // union of sorted sets
            Console.WriteLine("\n\nUnion of sorted1 and sorted3");
            SortedSet<int> sortedUnion = new SortedSet<int>();
            sortedUnion = sorted1 + sorted3; // union of sorted1 and sorted3      
            sortedUnion.DisplaySet();

            // sorted2 - type of string
            Console.WriteLine("\n\nsorted2");
            sorted2.DisplaySet();
            sorted2.Add("Dachi");
            sorted2.Remove("Mariam");
            sorted2.DisplaySet();
            
            // setOfP
            Console.WriteLine("\n\nsetOfP");
            setOfP.DisplaySet();

            // sortedSetOfP
            Console.WriteLine("\n\nsortedSetOfP");
            sortedSetOfP.DisplaySet();
           
            // Call Filter for FilterByEven
            Console.WriteLine("\n\nFiltered1 - even numbers");
            var filtered1 = set2.Filter(FilterByEven);
            filtered1.DisplaySet();
            // Call Filter for FilterByLetterA
            Console.WriteLine("\n\nFiltered2 - starts with 'A'");
            var filtered2 = sorted2.Filter(FilterByLetterA);
            filtered2.DisplaySet();
            Console.WriteLine();
        }
    }
    
    // test class
    class Person : IComparable<Person>
    {
        public string Name { get; set; }

        public Person(string name)  { Name = name; }

        public override string ToString()
        {
            return Name.ToString();
        }

        public int CompareTo(Person y)
        {
            return this != y ? Name.ToString().CompareTo(y.Name) : 0;
        }
    }
}
