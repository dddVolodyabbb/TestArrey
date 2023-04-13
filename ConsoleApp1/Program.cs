using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        private const int nomberCount = 20;
        private const int nomberStart = 0;
        private const int nomberEnd= 99;
        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            var arrey = Enumerable.Range(0, nomberCount)
                .Select(_ => rnd.Next(nomberStart, nomberEnd+1))
                .ToArray();
            arrey = arrey.OrderBy(x=>x).ToArray();
            Console.Write(string.Join(", ", arrey));
            Console.ReadKey();
        }
    }
}
