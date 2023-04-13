using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        private const int nomberCount = 20;
        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            var arrey = Enumerable.Range(0, nomberCount).Select(_ => rnd.Next(10)).ToArray();
            arrey = arrey.OrderBy(x=>x).ToArray();
            Console.Write(string.Join(", ", arrey));
            Console.ReadKey();
        }
    }
}
