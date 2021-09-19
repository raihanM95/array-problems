using System;
using System.Linq;

namespace ArrayProblems
{
    public class ArrayOperation
    {
        public void Sort(int[] array)
        {
            //int temp;

            // traverse 0 to array length
            for (int i = 0; i < array.Length; i++)

                // traverse i+1 to array length
                for (int j = i + 1; j < array.Length; j++)

                    // compare array element with 
                    // all next element
                    if (array[i] > array[j])
                    {

                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }

            // Sort array in ascending order. 
            //Array.Sort(array);

            // reverse array 
            //Array.Reverse(array);

            // print all element of array
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
        }
        public void FindMaxMin(int [] array)
        {
            // using Linq
            //int max = array.Max();
            //int min = array.Min();

            // using loop
            int max = array[0];
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            Console.Write("Maximum element = {0}\n", max);
            Console.Write("Minimum element = {0}\n\n", min);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] aArray = new int[5] { 95, 93, 99, 89, 87 };
            ArrayOperation objArray = new ArrayOperation();
            //objArray.FindMaxMin(aArray);
            objArray.Sort(aArray);
            //Console.WriteLine("Hello World!");
        }
    }
}
