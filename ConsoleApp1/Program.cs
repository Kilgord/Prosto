using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int n;
            int s=0;
            int q = 0;
            int f = 0;
            Console.WriteLine("Поиск займет пару секунд, ждите!");
            for(a=1; a < 10000 ; a++)
            {
               
                for (n = 1; n < a; n++)
                {
                    int c = a % n;
                    if (c == 0)
                    {
                        s = s + n;
                       


                    }
                }

                
                for (n = 1; n < s; n++)
                {
                    int c = s % n;
                    if (c == 0)
                    {
                        q = q + n;

                        

                    }
                }
                

                if (q == a & s != a)
                {
                    f = a + s;
                    
                }
                
                s = 0;
                q = 0;
            }
            Console.WriteLine("Сумма всех дружественных чисел: f=" + f);
            Console.ReadKey();

        }
    }
}
