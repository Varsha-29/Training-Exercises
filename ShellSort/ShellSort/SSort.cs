using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
    class SSort

    {
        public void ShellSort( int[] arr)
        {
            int size = arr.Length;
            for (int interval = size / 2; interval > 0; interval /= 2)
            {
                for (int i = interval; i < size; i++)
                {
                    int temp = arr[i];
                    int j;
                    for (j = i; j >= interval && arr[j - interval] > temp; j -= interval)
                        arr[j] = arr[j - interval];

                    arr[j] = temp;
                }
            }   
        }
        public void PrintArray(int[] arr)
        {
            int size = arr.Length;
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + "\t");
        }
        static void Main(string[] args)
        {
            int n;
            SSort shellSort = new SSort();
            Console.Write("\n Enter number of integers");
            n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Console.Write("\n Enter elements");
            for (int j = 0; j < n; j++)
                array[j] = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Elements before sorting\n\n");
            shellSort.PrintArray( array);
            shellSort.ShellSort(array);
            Console.WriteLine("\n Elements after sorting\n\n");
            shellSort.PrintArray(array);
            Console.Read();

        }
    }
}


