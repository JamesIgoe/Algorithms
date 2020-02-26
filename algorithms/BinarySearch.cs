namespace Algorithms
{
    class BinarySearch
    {
        public int Search(int num, int[] arrayToSearch)
        {
            int lowPosition = 0;
            int highPosition = arrayToSearch.Length - 1;
            
            while (highPosition >= lowPosition)
            {
                //correct calculation for the midpoint
                int position = lowPosition + ((highPosition - lowPosition) / 2);
            
                if (arrayToSearch[position] < num)
                {
                    lowPosition = position + 1;
                }
                else if (arrayToSearch[position] > num)
                {
                    highPosition = position - 1;
                }
                else
                {
                    return position;
                }
            }

            //value not found
            return -1;
        }
    }
}