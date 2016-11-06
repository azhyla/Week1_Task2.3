using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[60];
            Random r = new Random();
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = r.Next(-500, 500);
                Console.Write(Numbers[i] + " ");
                            }
            Console.Read();
        }
    }
}
