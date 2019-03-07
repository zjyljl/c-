using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 3, 0, -5, 36, 12, 64, 35, 15};
            Console.Write("数组元素为:");
            int sum = 0, aver = 0, max = arr[0], min = arr[0];
            foreach (int i in arr)
            {
                Console.Write(i + " ");
                sum += i;
                if (min > i) min = i;
                if (max < i) max = i;
            }
            aver = sum / arr.Length;
            Console.WriteLine("最大值:" + max + "   " + "最小值:" + min + "    " + "平均值:" + aver + "  " + "总和:" + sum);
        }
    }
}
