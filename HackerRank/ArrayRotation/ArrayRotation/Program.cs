﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);// lungimea vectorului
            int k = Convert.ToInt32(tokens_n[1]);// nr de permutari
            int q = Convert.ToInt32(tokens_n[2]);// cate pozitii iti cere

            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            for (int l = 0; l < k%n; l++)
            {
                int j = a.Last();
                for (int i = a.Length - 1; i > 0; i--)
                {
                    a[i] = a[i - 1];
                }
                a[0] = j;
            }

            for (int a0 = 0; a0 < q; a0++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a[m]);
            }


        }
    }
}
