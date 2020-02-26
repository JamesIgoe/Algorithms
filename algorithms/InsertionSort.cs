using System;
using System.Collections.Generic;

namespace Algorithms
{
    static class InsertionSort
    {
        /// <summary>
        /// Given a list of items, sorts by
        /// 1. examining each item from first position
        /// 2. calls method to insert value at correct sorted position
        /// </summary>
        /// <param name="startingList"></param>
        /// <returns></returns>
        public static IComparable[] Sort(IComparable[] startingList)
        {
            int arrayLength = startingList.Length;

            for (int counter = 0; counter < arrayLength; counter++)
            {
                startingList = Insert(startingList, counter);
            }
            return startingList;
        }

        /// <summary>
        /// 1. moves each value that is larger than current item's value back one
        /// 2. finaly inserting value at correct position for value
        /// </summary>
        /// <param name="list"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        private static IComparable[] Insert(IComparable[] list, int position)
        {
            int counter = position - 1;
            IComparable value = list[position];

            while (counter >= 0 && (list[counter].CompareTo(value) > 0))
            {
                list[counter + 1] = list[counter];
                counter = counter - 1;
            }

            list[counter + 1] = value;
            return list;
        }

        /// <summary>
        /// Given a list of items, sorts by
        /// 1. examining each item from starting index to endIndex, not necessarily the end of arry
        /// 1a.  starting and ending index alllows this to be used with quick sort and portions of arrays
        /// 2. calls method to insert value at correct sorted position
        /// </summary>
        /// <param name="startingList"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        public static int[] Sort(int[] startingList, int startIndex, int endIndex)
        {
            for (int counter = startIndex; counter <= endIndex; counter++)
            {
                startingList = Insert(startingList, counter);
            }
            return startingList;
        }

        /// <summary>
        /// 1. moves each value that is larger than current item's value back one
        /// 2. finaly inserting value at correct position for value
        /// </summary>
        /// <param name="list"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        private static int[] Insert(int[] list, int position)
        {
            int counter = position-1;
            int value = list[position];

            while (counter >= 0 && (list[counter].CompareTo(value) > 0))
            {
                list[counter + 1] = list[counter];
                counter = counter - 1;
            }

            list[counter + 1] = value;
            return list;
        }


        /// <summary>
        /// Given a list of items, sorts by
        /// 1. examining each item from starting index to endIndex, not necessarily the end of arry
        /// 1a.  starting and ending index alllows this to be used with quick sort and portions of arrays
        /// 2. calls method to insert value at correct sorted position
        /// </summary>
        /// <param name="startingList"></param>
        /// <returns></returns>
        public static List<int> Sort(List<int> startingList)
        {
            for (int counter = 0; counter < startingList.Count; counter++)
            {
                startingList = Insert(startingList, counter);
            }
            return startingList;
        }

        /// <summary>
        /// 1. moves each value that is larger than current item's value back one
        /// 2. finaly inserting value at correct position for value
        /// </summary>
        /// <param name="list"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        private static List<int> Insert(List<int> list, int position)
        {
            int counter = position - 1;
            int value = list[position];

            while (counter >= 0 && (list[counter].CompareTo(value) > 0))
            {
                list[counter + 1] = list[counter];
                counter = counter - 1;
            }

            list[counter + 1] = value;
            return list;
        }
    }
}
