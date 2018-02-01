using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeftRotationArrayList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] balance1 = { 23, 4, 34, 22, 15, 12, 11 };
            int[] balance2 = { 23, 4, 34, 22, 15, 12, 11 };
            balance1 = rotateArrayUsingTempArray(balance1, 12);
            foreach (int num in balance1)
                Console.Write(num + " ");

            balance2 = leftRotateOneByOne(balance2, 12, balance2.Length);
        }


        public static int[] rotateArrayUsingTempArray(int[] arr, int rotationAmount)
        {

            // Because the constraints state d < n, we need not concern ourselves with shifting > n units.
            int arrayLength = arr.Length;
            if (rotationAmount > arrayLength)
                rotationAmount = rotationAmount % arrayLength;


            // Create new array for rotated elements:
            int[] rotated = new int[arrayLength];

            // Copy segments of shifted elements to rotated array:
            Array.Copy(arr, rotationAmount, rotated, 0, arrayLength - rotationAmount);
            Array.Copy(arr, 0, rotated, arrayLength - rotationAmount, rotationAmount);

            return rotated;
        }

        /*Function to left rotate arr[] of size n by d*/
        public static int[] leftRotateOneByOne(int[] arr, int rotationAmount, int sizOfArray)
        {
            if (rotationAmount > sizOfArray)
                rotationAmount = rotationAmount % sizOfArray;

            for (int i = 0; i < rotationAmount; i++)
                leftRotatebyOne(arr, sizOfArray);

            return arr;
        }

        public static void leftRotatebyOne(int[] arr, int size)
        {
            int i, currentNumberBeingPushedToBack;
            currentNumberBeingPushedToBack = arr[0];
            for (i = 0; i < size - 1; i++)
                arr[i] = arr[i + 1];
            arr[i] = currentNumberBeingPushedToBack;
        }


    }
}
