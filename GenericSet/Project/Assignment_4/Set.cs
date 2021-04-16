using System;
using System.Collections;
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
    // delegate for Filter()
    public delegate bool F<T>(T e);
    
    class Set<T> : IEnumerable<T> 
    {
        // using list for to create sets
        public List<T> mySet = new List<T>();

        //This property returns the number of elements in the set.
        //This property should be readable but not writable.
        private int Count => mySet.Count;           
        //This property returns true if there are no items in the set. 
        //This property should be readable but not writable.
        private bool IsEmpty => mySet.Count == 0;

        // default constructor
        public Set(){ }

        //constructor that fills the set with all the elements in some enumerable collection.
        public Set(IEnumerable<T> e)
        {
            foreach(T item in e)
            {
                mySet.Add(item);
            }            
        }
        // This method returns true if the input element is in the set.
        public bool Contains(T item)
        {
            return mySet.Contains(item);
        }
        //This method adds the input element to the set.
        //It returns true if the element is added to the set, 
        //and false if the element is already present in the set.
        public virtual bool Add(T item)
        {
            if (mySet.Contains(item))
            {
                return false; // if item is already in set
            }
            mySet.Add(item); // if not in set, add item to list
            return true;
        }
        // This method removes the input element from the set. 
        // It returns true if the element is removed to the set,
        // and false if the element was not in the set to begin with.
        public virtual bool Remove(T item)
        {
            if (!mySet.Contains(item))
            {
                return false; // if item is not in set
            }
            mySet.Remove(item);
            return true;
        }
        //This method takes a delegate of type bool F<T>(T elt) and returns
        //all the elements in the set for which this function returns true.
        public Set<T> Filter(F<T> filterFunction)
        {
            F<T> d1 = new F<T>(filterFunction); // instance of delegate
            Set<T> tempSet = new Set<T>(); // temporary set for filtered items
            foreach (T item in mySet)
            {
                if (d1(item))
                {
                    tempSet.Add(item); // add elements to tempset
                }
            }
            return tempSet; // return filtered set
        }

        // This operator implements set union: it should return a new
        // set that contains any item contained in either the lhs or the rhs set.        
        public static Set<T> operator +(Set<T> lhs, Set<T> rhs)
        {
            Set<T> union = new Set<T>(); 
            foreach(T i in lhs)
            {
                union.Add(i); // add lhs items
                foreach(T j in rhs)
                {
                    if (!lhs.Contains(j))
                    {
                        union.Add(j); // if not already in set, add rhs items
                    }                    
                }
            } 
            return union;
        }  

        // IEnumerable implementation
        public IEnumerator<T> GetEnumerator()
        {
            return mySet.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        // display results for objects
        public void DisplaySet()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Empty: " + IsEmpty);
            Console.WriteLine("Size:  " + Count);
            Console.Write("Set:   { ");
            foreach (var i in this)
            {
                Console.Write(i + " ");
            }
            Console.Write("}\n");
        }
    }
}
