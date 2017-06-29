using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Collection
    {
        public void PrintArrayList(ArrayList aList)
        {
            foreach (int val in aList)
                Console.Write("\t" + val);
            Console.WriteLine();
        }
        public void PrintHashTable(Hashtable hashTable)
        {
            ICollection keys = hashTable.Keys;
            foreach (int key in keys)
                Console.WriteLine("Key\t\t" + key + "\t\t value:\t\t" + hashTable[key]);
            Console.WriteLine();
        }
        public void ArrayListOperations()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add(89);
            arrayList.Add(29);
            arrayList.Add(-1);
            arrayList.Add(15);
            PrintArrayList(arrayList);
            arrayList.Sort();
            arrayList.Insert(2, 18);
            PrintArrayList(arrayList);
            Console.WriteLine("\nArraylist capacity\t" + arrayList.Capacity);
            int hasElement = arrayList.IndexOf(23);
            if (hasElement >= 0)
                Console.WriteLine("Element is present");
            else
                Console.WriteLine("Element is not present");
            arrayList.TrimToSize();
            Console.WriteLine("\nArraylist capacity\t" + arrayList.Capacity);
            int[] arr = { 14, 17 };
            arrayList.AddRange(arr);
            PrintArrayList(arrayList);
            arrayList.InsertRange(3, arr);
            PrintArrayList(arrayList);
            arrayList.SetRange(7, arr);
            PrintArrayList(arrayList);
        }
        public void HashTableOperations()
        {
            Hashtable hashTable = new Hashtable();
            hashTable.Add(101, "suchi");
            hashTable.Add(103, "vibha");
            hashTable.Add(106, "kirthana");
            hashTable.Add(102, "francis");
            PrintHashTable(hashTable);
            bool hasKey=hashTable.ContainsKey(102);
            Console.WriteLine(hasKey);
            hashTable.Remove(103);
            PrintHashTable(hashTable);
        }
 
        static void Main(string[] args)
        {
            Collection collection = new Collection();
            collection.ArrayListOperations();
            collection.HashTableOperations();
            Console.ReadKey();
        }
    }
}
