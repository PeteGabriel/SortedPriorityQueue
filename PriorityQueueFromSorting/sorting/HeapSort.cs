using System;
using System.Collections.Generic;
using System.Linq;

namespace PriorityQueueFromSorting.sorting
{
    /// <summary>
    /// 
    /// </summary>
    public static class HeapSort<T> where T: IComparable<T> 
    {
        #region PublicApi
        
        public static IEnumerable<T> Sort(IEnumerable<T> sequence)
        {
            
        }

        public static T[] Sort(T[] sequence)
        {
            var sortedSequence = new T[sequence.Length];
            CopySequence(sequence, sortedSequence);
            
            Heapify(sortedSequence);  
            ShrinkHeap(sortedSequence);  
            
            return sortedSequence;
        }

        #endregion
        
        #region private

        private static void Heapify(T[] table)  
        {  
            for (int child = 1; child < table.Length; child++)  
            {  
                int parent = (child - 1) / 2;  
                while (parent >= 0 && table[parent].CompareTo(table[child]) < 0)  
                {  
                    Swap(table, parent, child);  
                    child = parent;  
                    parent = (child - 1) / 2;  
                }  
            }  
        }
        
        private static void ShrinkHeap(T[] table)  
        {  
            for (int n = table.Length-1; n >= 0; n--)  
            {  
                Swap(table, 0, n);  
                int parent = 0;  
                while (true)  
                {  
                    int leftChild = 2 * parent + 1;  
                    if (leftChild >= n)  
                        break; // no more children  
                    int rightChild = leftChild + 1;  
                    int maxChild = leftChild;  
                    if (rightChild < n && table[leftChild].CompareTo(table[rightChild]) < 0)  
                        maxChild = rightChild;  
                    if (table[parent].CompareTo(table[maxChild]) < 0)  
                    {  
                        Swap(table, parent, maxChild);  
                        parent = maxChild;  
                    }  
                    else  
                        break; // exit loop  
                }  
            }  
        }  
        
        private static void Swap(T[] sequence, int parent, int child)
        {
            var temp = sequence[parent];  
            sequence[parent] = sequence[child];  
            sequence[child] = temp; 
        }
        
        private static void CopySequence(T[] sequence, T[] newCopy)
        {
            for (int i = 0; i < sequence.Length; i++)
            {
                newCopy[i] = sequence[i];
            }
        }
        #endregion

    }
}