using System.Collections.Generic;

namespace Algorithms
{
    static class Enumerables
    {
        public static IEnumerable<int> GetNaturalNumbers(int maxValue)
        {
            int num = 0;
            while (maxValue >= num)
            {
                yield return num++;
            }
        }

        public static IEnumerable<int> GetFibonacciSequence(int maxCount)
        {
            int firstNum = 0;
            int secondNum = 1;
            int newNum = 0;

            int counter = 0;
            while (counter <= maxCount)
            {
                yield return newNum;
                counter += 1;
                newNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = newNum;                     
            }
        }

        public static int GetFibonacciItem(int count)
        {
            int firstNum = 0;
            int secondNum = 1;
            int newNum = 0;

            int iterations = 1;
            while (iterations <= count)
            {
                newNum = firstNum + secondNum;
                iterations += 1;
                firstNum = secondNum;
                secondNum = newNum;
            }
            return newNum;
        }
        
        public static IEnumerable<double> GetFibonacciSequenceLimit()
        {
            int itemCounter = 1;
            double numerator;
            double denominator;
            double newValue;
            double oldValue=0;
            while (true)
            {
                numerator = GetFibonacciItem(itemCounter);
                itemCounter += 1;
                denominator = GetFibonacciItem(itemCounter);

                newValue = denominator / numerator;

                if (oldValue != newValue)
                {
                    yield return newValue;
                    oldValue = newValue;
                }
                else
                {
                    yield break;
                }
            }
        }
    }
}
