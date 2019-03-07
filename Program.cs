using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6
{
    class Program
    {
     static bool Isprime(int n)//判断整数n是否为素数
        {
            int i;
            for (i = 2; i <=Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
                if (i > Math.Sqrt(n))
                {
                    return true;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int n;
            string s;
            Console.Write("输入一个数:");
            s = Console.ReadLine();
            n = int.Parse(s);
            Console.Write(n + "的所有素数因子为:");
            for(int i=2;i<n;++i)
            {
                if (n % i == 0 && Isprime(i))
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
