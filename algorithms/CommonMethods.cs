using System.Collections.Generic;

namespace Algorithms
{
    static class CommonMethods
    {
        public static int[] Swap(int[] arrayToUse, int itemOneIndex, int itemTwoIndex)
        {
            int tempValueHolder = arrayToUse[itemOneIndex];
            arrayToUse[itemOneIndex] = arrayToUse[itemTwoIndex];
            arrayToUse[itemTwoIndex] = tempValueHolder;
            return arrayToUse;
        }

        public static List<int>[] CreateHashedArray(int[] arrayToSort, int buckets)
        {
            List<int>[] bucketList;

            //get min and max of array
            int min = arrayToSort[0];
            int max = arrayToSort[0];
            foreach (int num in arrayToSort)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }

            //create linkedlist of buckets
            int bucketSize = (max - min) / buckets + 1;
            bucketList = new List<int>[bucketSize];
            foreach (int num in arrayToSort)
            {
                int hash = HashFunction(num, buckets);
                if (bucketList[hash] == null)
                {
                    bucketList[hash] = new List<int>();
                }
                bucketList[hash].Add(num);
            }

            return bucketList;
        }

        public static int HashFunction(int num, int buckets)
        {
            return num / buckets;
        }

    }
}
