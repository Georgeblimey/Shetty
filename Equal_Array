using System;

namespace ConsoleApp53
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];
            int cnt = 0;
            int flag = 0;
            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");

            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write(b[i] + " ");

            }
            Console.WriteLine();
            int one=0,zero = 0;
            for(int i = 0; i < n; i++)
            {
                if (a[i] == 1)
                {
                    one++;
                    if (b[i] == 1)
                    {
                        one++;
                    }
                }
                else if (a[i] == 0)
                {
                    zero++;
                    if (b[i] == 0)
                    {
                        zero++;
                    }
                }
            }

            for (int i =0; i < n; i++)
            {
             
                    if (a[i] == b[i])
                    {
                    continue;

                }

                else
                {
                    
                    for(int j = i+1; j < n; j++)
                    {
                        if (a[i] == b[j])
                        {
                            int temp = b[j];
                            b[j] = b[i];
                            b[i] = temp;
                            cnt++;
                            break;
                        }
                        else
                        {
                            if (one % 2 == 0 || zero % 2 == 0)
                           
                            {
                                int temp = a[i];
                                a[i] = b[j];
                                b[j] = temp;
                                cnt++;
                                break;
                               

                            }
                        }
                       
                    }
                }

                
                
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");

            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(b[i] + " ");

            }
            Console.WriteLine();
            if (one % 2 != 0 || zero % 2 != 0)
            {


                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(cnt);
            }
            Console.ReadLine();
        }
    }
}
