using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitHop
{
    class Program
    {
        public static int Fibo(int hop)
        {
            if(hop == 0)
            {
                return 0;
            }

            if(hop == 1)
            {
                return 1;
            }
            return (Fibo(hop - 1) + Fibo(hop - 2));
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of hops:");
            int hop = Convert.ToInt32(Console.ReadLine());
            hop = hop + 1;
            Console.WriteLine(Fibo(hop));
        }
    }
}
