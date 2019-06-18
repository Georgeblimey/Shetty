using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace ConsoleApp54
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int p = 0; p <t; p++)
            {



                int n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                for (int l = 0; l < n; l++)
                {
                    a[l] = int.Parse(Console.ReadLine());
                }
                int key = int.Parse(Console.ReadLine());
                int i = 0;
                int v = 0;



                while ((int)(n / (Math.Pow(2, i))) != 0)
                {
                    v++;
                    i++;
                }


                int max = 0;


                for (int d = 0, z = n; z != 0; d++)
                {
                    max = max + (n * z) * (d + 1);
                    z = z / 2;
                }


                int[] b = new int[max];
                int ma = 0; ;
                for (int j = 0; j < v; j++)
                {
                    int q = n * (j + 1);

                    while (q != 0)
                    {
                        int c = (int)(n / (Math.Pow(2, j)));

                        for (int k = 0; k < c; k++)
                        {
                            b[ma] = a[k];
                            ma++;
                        }
                        q--;
                    }

                }
                Array.Sort(b);
                for (int l = 0; l < max; l++)
                {


                    Console.Write(b[l]);
                }
                Console.WriteLine();
                Console.WriteLine(b[key - 1]);
            }
            Console.ReadLine();

        }
    }
}
