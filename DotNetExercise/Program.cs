using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetExercise
{
    public class Program
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Sum(7, 9));
            Console.ReadKey();
        }
    }
}
