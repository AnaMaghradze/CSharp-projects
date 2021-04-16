using System;
using System.Collections.Generic;

/// <summary>
/// Ana Maghradze
/// 823356346
/// </summary>
namespace COMPE361
{
    class SortedSet<T> : Set<T> where T : IComparable<T>
    {
        // default constructor
        public SortedSet() { }

        // explicit value constructor 
        public SortedSet(IEnumerable<T> e) : base(e) { }

        // override Add for SortedSet
        public override bool Add(T item)
        {
            if (mySet.Contains(item))
            {
                return false; // if item is already in set
            }
            mySet.Add(item);
            mySet.Sort(); // sort set after item is added
            return true;
        }
        // override Add For SortedSet
        public override bool Remove(T item)
        {
            if (!mySet.Contains(item))
            {
                return false;
            }
            mySet.Remove(item);
            return true;
        }
        
        // + operator for unions
        public static SortedSet<T> operator +(SortedSet<T> lhs, SortedSet<T> rhs)
        {
            SortedSet<T> union = new SortedSet<T>();
            foreach (T i in lhs)
            {
                union.Add(i);
                foreach (T j in rhs)
                {
                    if (!lhs.Contains(j))
                    {
                        union.Add(j);
                    }
                }
            }
            return union;
        }

        public int CompareTo(Object obj)               
        {
            SortedSet<T> other = obj as SortedSet<T>;
            return this.CompareTo(other);
            throw new NotImplementedException();
        }        
    }
}
    

