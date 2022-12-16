using System;

namespace SearchAlgorithm
{
    class Program
    { 
        //Array to be searched
        int[] arr = new int[20];
        //Number of elements in the array 
        int n;
        //Get the number of elements to store in the array
        int i;
        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 20 elements.\n");
            }
            //Accept array elements 
            Console.WriteLine("");
            Console.WriteLine("--------------------");
            Console.WriteLine("Enter array elements");
            Console.WriteLine("--------------------");
            for (i = 0; i<n; i ++)
            {
                Console.WriteLine("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        public void BinarySearch()
        {
            char ch;
            do
            {
                //Accept the number to be search
                Console.Write("Enter element want to you search: ");
                int item = Convert.ToInt32(Console.ReadLine());
                //Apply binary search
                int lowerbound = 0;
                int upperbound = n - 1;
                //obtain the index of the elements in the array
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;
                //loop to search for the elements in the array
                while ((item 1 = arr[mid]) && (lowerbound <= upperbound))
                    {
                    if (item > arr[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;
                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
                if (item == arr[mid])
                    Console.WriteLine("\n" + item.ToString() + "found at position" + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + "not found in the array\n");
                Console.WriteLine("\nNumber of comparation: " + ctr);
                Console.Write("\nContinue Search (y/n): ");
                ch = char.Parse(Console.ReadLine());
            }
            while ((ch == 'y') || (ch == 'Y'));
        }
        public void LinearSearch()
        {
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
