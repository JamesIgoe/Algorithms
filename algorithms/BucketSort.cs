using System.Collections.Generic;

namespace Algorithms
{
    class BucketSort
    {
        public int[] Sort()
        {   
            //creates array
            int[] arrayToSort = { 11, 7, 22, 2, 33, 3, 17, 44, 4, 55, 5, 66, 6, 1, 77 };

            //create bucket using hash, x/3
            List<int>[] bucketList = CommonMethods.CreateHashedArray(arrayToSort, 10);
            
            //sort the bucket list back into the original array
            int[] newArray = ReorderList(bucketList, arrayToSort);

            return newArray;
        }

        int _reorderPosition;
        private int[] ReorderList(List<int>[] buckets, int[] originalArray)
        {
            foreach (List<int> lst in buckets)
            {
                if (lst != null && lst.Count > 0)
                {
                    List<int> innerList = InsertionSort.Sort(lst);

                    for (int innerCounter = 0; innerCounter < lst.Count; innerCounter++)
                    {
                        originalArray[_reorderPosition] = innerList[innerCounter];
                        _reorderPosition++;
                    }
                }
            }
            return originalArray;
        }
    }
}
