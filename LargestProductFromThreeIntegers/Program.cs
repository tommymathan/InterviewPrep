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
            int secondHighestNum = HighestProductOf3BruteForce(arrayOfInts);
            int highestNumProduct4 = HighestProductof4BruteForce(arrayOfInts);
            int highestNum = HighestProductOf3(arrayOfInts);
        }

        public static int HighestProductOf3BruteForce(int[] arrayOfInts)
        {
            int currentHighest = 0;
            int count = 0;
            for (int i = 0; i < arrayOfInts.Length - 2; i++)
            {
                count++;
                for(int j = i + 1; j < arrayOfInts.Length -1; j++)
                {
                    count++;
                    for(int k= j + 1; k <arrayOfInts.Length; k++)
                    {
                        count++;
                        int current = arrayOfInts[i] * arrayOfInts[j] * arrayOfInts[k];
                        if(current > currentHighest)
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
            for(int i = 0; i < arrayofInts.Length - 3; i++)
            {
                for(int j = i+1; j < arrayofInts.Length-2; j++)
                {
                    for(int k = j +1; k < arrayofInts.Length - 1; k++)
                    {
                        for(int l = k + 1; l < arrayofInts.Length; l++)
                        {
                            int current = arrayofInts[i] * arrayofInts[j] * arrayofInts[k] * arrayofInts[l];
                            if(current > currentHighest)
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
        public static int HighestProductOf3(int[] arrayOfInts)
        {

            
        }
    }






}
