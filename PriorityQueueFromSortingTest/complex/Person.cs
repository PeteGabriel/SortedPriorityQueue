using System;

namespace PriorityQueueFromSortingTest.complex
{
    public class Person
    {
        public String Name { get; set; }

        public Disease Disease { get; set; }
    }


    public class Disease: IComparable
    {
        public String Name { get; set; }
        public int Degree { get; set; }
      
        public int CompareTo(object obj)
        {
            if (obj is Disease tmp)
            {
                return this.Degree.CompareTo(tmp.Degree);
            }
            
            return 1; // first is "bigger"
        }
    }
}