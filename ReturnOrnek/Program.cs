using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Gather(5, 7);
            Console.WriteLine("Toplam: " + result);

            Console.ReadLine();
        }

        public static int Gather(int a, int b)
        {
            return a + b;
        }
    }
    }
