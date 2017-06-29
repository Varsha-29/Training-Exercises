using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class HSort
    {
       
        public void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public void Heapify(int[] arr, int size, int currIndex)
        {
            int largest = currIndex;
            int left = 2 * currIndex + 1;
            int right = 2 * currIndex + 2;
            if (left < size && arr[left] > arr[largest])
                largest = left;
            if (right < size && arr[right] > arr[largest])
                largest = right;
            if (largest != currIndex)
            {
                Swap(ref arr[currIndex],ref arr[largest]);
                Heapify(arr, size, largest);

            }

        }
        public void BuildHeap(ref int[] arr)
        {
            int size = arr.Length;
            for (int i = (size / 2) - 1; i >= 0; i--)
                Heapify(arr, size, i);
            for (int i = size - 1; i >= 0; i--)
            {
                Swap(ref arr[0], ref arr[i]);
                Heapify(arr, i, 0);
            }
            
        }
        public void PrintArray(ref int[] arr)
        {
            int size = arr.Length;
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + "\t");
        }
         static void Main(string[] args)
        {
            int n;
            HSort heapSort = new HSort();
            Console.Write("\n Enter number of integers");
            n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Console.Write("\n Enter elements");
            for (int j = 0; j < n; j++)
                array[j] = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Elements before sorting\n\n");
            heapSort.PrintArray(ref array);
            heapSort.BuildHeap(ref array);
            Console.Write("\n Elements After Sorting\n\n");
            heapSort.PrintArray(ref array);
            Console.ReadKey();
        }

    }

}
