using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4._2_Средний_Вар_2
{
    internal class Program
    {
        const int N = 4;
        static void Main()
        {
            int[,] a = new int[N, N];
            for (int i = 0; i < N; ++i)
                for (int j = 0; j < N; ++j)
                    if ((i + j) % 2 == 0)
                        a[i, j] = 0;
                    else
                        a[i, j] = 1;

            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < N; ++j)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
