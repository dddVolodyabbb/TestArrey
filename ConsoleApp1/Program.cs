using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]=random.Next(0,11);
            }

            foreach (var i in arr)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Array.Sort(arr);
            foreach (var i in arr)
            {
                Console.Write(i+ " ");
            }
            Console.ReadKey();
        }
    }
}
