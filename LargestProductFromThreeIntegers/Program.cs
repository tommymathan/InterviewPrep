using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestProductFromThreeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfInts = { 1, 10, -5, 3, -100 };
            int secondHighestNum = HighestProductOf3Optimal(arrayOfInts);
            int highestNumProduct4 = HighestProductof4BruteForce(arrayOfInts);
            int highestNum = HighestProductOf3Optimal(arrayOfInts);
        }

        public static int HighestProductOf3BruteForce(int[] arrayOfInts)
        {
            int currentHighest = 0;
            int count = 0;
            for (int i = 0; i < arrayOfInts.Length - 2; i++)
            {
                count++;
                for (int j = i + 1; j < arrayOfInts.Length - 1; j++)
                {
                    count++;
                    for (int k = j + 1; k < arrayOfInts.Length; k++)
                    {
                        count++;
                        int current = arrayOfInts[i] * arrayOfInts[j] * arrayOfInts[k];
                        if (current > currentHighest)
                        {
                            currentHighest = current;
                        }
                    }
                }
            }

            return currentHighest;
        }

        public static int HighestProductof4BruteForce(int[] arrayofInts)
        {
            int currentHighest = 0;
            for (int i = 0; i < arrayofInts.Length - 3; i++)
            {
                for (int j = i + 1; j < arrayofInts.Length - 2; j++)
                {
                    for (int k = j + 1; k < arrayofInts.Length - 1; k++)
                    {
                        for (int l = k + 1; l < arrayofInts.Length; l++)
                        {
                            int current = arrayofInts[i] * arrayofInts[j] * arrayofInts[k] * arrayofInts[l];
                            if (current > currentHighest)
                            {
                                currentHighest = current;
                            }
                        }
                    }
                }
            }
            return currentHighest;
        }

        //highestProductOf3
        //highestProductOf2
        //highest
        //lowestProductOf2
        //lowest
        public static int HighestProductOf3Optimal(int[] arrayOfInts)
        {
            int highest = Math.Max(arrayOfInts[0], arrayOfInts[1]);
            int lowest = Math.Min(arrayOfInts[0], arrayOfInts[1]);
            int highestProductofTwo = arrayOfInts[0] * arrayOfInts[1];
            int lowestProductofTwo = arrayOfInts[0] * arrayOfInts[1];
            int highestProductofThree = arrayOfInts[0] * arrayOfInts[1] * arrayOfInts[2];
            for (int i = 2; i < arrayOfInts.Length; i++)
            {
                int current = arrayOfInts[i];
                highestProductofThree = Math.Max(highestProductofThree, Math.Max(current * highestProductofTwo, current * lowestProductofTwo));
                highestProductofTwo = Math.Max(highestProductofTwo, Math.Max(current * highest, current * lowest));
                lowestProductofTwo = Math.Min(lowestProductofTwo, Math.Min(current * highest, current * lowest));
                highest = Math.Max(highest, current);
                lowest = Math.Max(lowest, current);
            }
            return highestProductofThree;

        }


        public static int[] HighestAndLowestProductOf3Optimal(int[] arrayOfInts)
        {
            int currentIndex;
            int[] highestandLowestProductof3 = new int[2];
            int highest = Math.Max(arrayOfInts[0], arrayOfInts[1]);
            int highestIndex;
            int lowest;
            int lowestIndex;
            if(arrayOfInts[0] > arrayOfInts[1])
            {
                highestIndex = 0;
                lowestIndex = 1;
                highest = arrayOfInts[0];
                lowest = arrayOfInts[1]; 
            }
            else
            {
                highestIndex = 1;
                lowestIndex = 0;
                highest = arrayOfInts[1];
                lowest = arrayOfInts[0];
            }


            int highestProductofTwo = arrayOfInts[0] * arrayOfInts[1];
            int lowestProductofTwo = arrayOfInts[0] * arrayOfInts[1];
            int highestProductofThree = arrayOfInts[0] * arrayOfInts[1] * arrayOfInts[2];
            int LowestProductofThree = arrayOfInts[0] * arrayOfInts[1] * arrayOfInts[2];

            int[] highestProductofThreeIndexs = new int[3];
            highestProductofThreeIndexs[0] = 0;
            highestProductofThreeIndexs[1] = 1;
            highestProductofThreeIndexs[2] = 2;

            for (int i = 2; i < arrayOfInts.Length; i++)
            {
                int current = arrayOfInts[i];
                
                highestandLowestProductof3[0] = Math.Max(highestProductofThree, Math.Max(current * highestProductofTwo, current * lowestProductofTwo));
                highestandLowestProductof3[1] = Math.Min(LowestProductofThree, Math.Max(current * highestProductofTwo, current * lowestProductofTwo));

                if(highestProductofTwo < Math.Max(current * highest, current * lowest))
                {

                }

                highestProductofTwo = Math.Max(highestProductofTwo, Math.Max(current * highest, current * lowest));
                if(highestPro)

                lowestProductofTwo = Math.Min(lowestProductofTwo, Math.Min(current * highest, current * lowest));
                highest = Math.Max(highest, current);
                lowest = Math.Max(lowest, current);
                currentIndex = i;
            }
            return highestandLowestProductof3;
        }

        public static int HighestProductOf4Optimal(int[] arrayOfInts)
        {
            int[] highestandLowestProductofThree = HighestAndLowestProductOf3Optimal(arrayOfInts);

            int highestProductofThree = highestandLowestProductofThree[0];
            int lowestProductofThree = highestandLowestProductofThree[1];
            int highestProductofFour = arrayOfInts[0] * arrayOfInts[1] * arrayOfInts[2] * arrayOfInts[3];

            for (int i = 3; i < arrayOfInts.Length; i++)
            {
                int current = arrayOfInts[i];
                highestProductofFour = Math.Max(highestProductofFour, Math.Max(current * highestProductofThree, current * lowestProductofThree));
                highestProductofThree = Math.Max(highestProductofThree, Math.Max(current * highestProductofTwo, current * lowestProductofTwo));
                lowestProductofThree = Math.Min(lowestProductofThree, Math.Min(current * highest, current * lowest));
                highest = Math.Max(highest, current);
                lowest = Math.Max(lowest, current);
            }
            return highestProductofThree;

        }

    }

}
