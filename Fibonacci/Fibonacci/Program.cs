using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {
       public static List<int> calc(List<int> fib, int quant)//calculo sequencia fibonacci
        {
            int auxprev = 1;
            int auxnext=0;
            fib.Add(auxprev);
            while (fib.Count != quant+1)
            {
                if (fib.Count <2)
                {
                    auxnext = auxprev;
                  fib.Add(auxnext);
                }
                else
                {
                    auxnext += auxprev;
                    fib.Add(auxnext);
                    auxprev = auxnext-auxprev;
                }                    
                
            }
            return fib;
        }
        public static void sequence(List<int> fib)
        {
            int quant=0;
            Console.WriteLine("Informe a quantidade de sequencia de Fibonacci:");
            quant = int.Parse(Console.ReadLine());
            Console.WriteLine("Sequencia de Fibonacci: ");
            imprime(calc(fib,quant));
            
        }
        public static  void imprime(List<int> fib)
        {
            foreach(var valor in fib)
            {
                Console.Write(" "+valor);
            }
        }
        static void Main(string[] args)
        {
            int quantidade=0;
            List<int> _fibonacci=new List<int>();
             sequence(_fibonacci);
            Console.ReadKey();

        }
    }
}
