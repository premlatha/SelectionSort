/// <summary>
/// Selection Sort Console application
/// </summary>
namespace SelectionSort
{
    using System;

    /// <summary>
    /// Main Class
    /// </summary>
    public class Program
    {
       public static void Main(string[] args)
        {
            int[] unSortedArray = new int[10] { 100, 50, 20, 40, 10, 70, 90, 120, 60, 80 };
            Console.WriteLine("Array before Selection sort....");
            DisplayArrayElements(unSortedArray);
            int[] sortedArray = PerformSelectionSort(unSortedArray);
            Console.WriteLine("Array after selection Sort....");
            DisplayArrayElements(sortedArray);
            Console.ReadLine();
        }

        /// <summary>
        /// Used to perform selection sort on a array of integers
        /// </summary>
        /// <param name="array">Integer array to perform Selection sort on</param>
        /// <returns>Sorted Array</returns>
        public static int[] PerformSelectionSort(int[] array)
        {
            int temp, minKey, arraySize;
            arraySize = array.Length;
            for (int i = 0; i < arraySize - 1; i++)
            {
                minKey = i;
                for (int j = i + 1; j < arraySize; j++)
                {
                    if (array[j] < array[minKey])
                    {
                        minKey = j;
                    }
                }

                temp = array[minKey];
                array[minKey] = array[i];
                array[i] = temp;
            }

            return array;
        }

        /// <summary>
        /// Used to display the array contents in the console
        /// </summary>
        /// <param name="array">Integer array to be displayed</param>
        private static void DisplayArrayElements(int[] array)
        {
            if (array != null)
            {
                int arraySize = array.Length;
                for (int i = 0; i < arraySize; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
