using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp50
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int []x=new int[M];
            for(int i = 0; i < M; i++)
            {
                x[i] = int.Parse(Console.ReadLine());
            }
            int sum;
            for(int i = 0; i < M; i++)
            {
                sum = 0;
                int B = A; 
                if (x[i] == x[0])
                {
                  sum= 1 + B;
                   
                }
                else
                {
                   
                    int D = i;
                    int[] temp = new int[i+1];
                    for(int k = 0; k < i+1; k++)
                    {
                        temp[k] = x[k];
                    }
                    Array.Sort(temp);
                    for (int j = D; j >= 0; j--)
                    {
                        if (j == 0)
                        {
                            sum = sum + B + 1;
                        }
                        else
                        {
                            sum = sum + (B + (temp[j - 1] + 1));
                            B = temp[j] - 1;
                        }

                        
                    }

                }
                Console.WriteLine(sum);

            }
            Console.ReadKey();


        }
    }
}
