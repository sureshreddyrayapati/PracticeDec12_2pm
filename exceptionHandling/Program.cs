using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling
{
    class MyError:ApplicationException
    {
        public void waterOverFlowException()
        {
            Console.WriteLine("Exception Happend tank is full");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // int number = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(Suresh(number));
            // String word=Console.ReadLine();
            // Console.WriteLine(recString(word));
            try
            {
                Console.WriteLine("Fill the can of water in liters\n How meny liters");
                int water = Convert.ToInt32(Console.ReadLine());
                if(water>=100)
                {
                    throw new MyError(); 
                }
                else
                {
                    Console.WriteLine($"Tank is filled with {water} liters");
                }
                
            }
            catch (MyError e)
            {
                e.waterOverFlowException();
            }
        }
        public static int Suresh(int a)
        {
            int rev = 0;
            while(a>0)
            {
                int x = a % 10;
                rev = rev * 10 + x;
                a = a / 10;
            }
            return rev;
        }
        public static string recString(string w)
        {
            String d = "";
            for(int i=w.Length-1;i>=0;i--)
            {
                char s = w.ToCharArray()[i];
                d = d + s;
            }
            return d;   
        }

    }
    
}
