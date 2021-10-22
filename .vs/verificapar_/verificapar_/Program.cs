using System;

namespace verificapar_
{
    class Program
    {
        public static int recebe_numero(int numero)//recebe um valor inteiro e o retorna
        {
            Console.WriteLine("Digite um Valor Inteiro:");
            numero = int.Parse(Console.ReadLine());
            return numero;
        }
        public static void verificapar(int num) //verifica se o numero informado é par ou impar
        {
            if (num % 2 == 0)
            {
                imprime(num);
                Console.Write(" é par");
            }
            imprime(num);
            Console.Write(" é impar");
        }
        public static void imprime(int num)
        {
            Console.WriteLine("o numero Numero: "+num);
        }
        static void Main(string[] args)
        {
            int numero=0;
            numero=recebe_numero(numero);
            verificapar(numero);
            Console.ReadKey();
        }
    }
}
