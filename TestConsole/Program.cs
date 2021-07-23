using System;

namespace TestConsole
{
    
    class Program
    {
        static void Main(string[] args)
        {
            
            int a, b;
            a = 5;
            b = 3;


            var sum = Sum(a, b);

            
            Console.WriteLine(sum);
        }

        
        public static int Sum(int a, int b)
        {
            return a + b;
            

        }
    }
}
