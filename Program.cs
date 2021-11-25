using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1;
            string nome2;
            string nome3;
            int idade1;
            int idade2;
            int idade3;

            Console.WriteLine("digite o primeiro nome");
            nome1 = Console.ReadLine();

            Console.WriteLine("digite a idade");
            idade1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("digite o segundo nome");
            nome2 = Console.ReadLine();
            Console.WriteLine("digite a idade");
            idade2 = int.Parse(Console.ReadLine());


            Console.WriteLine("digite o terceiro nome");
            nome3 = Console.ReadLine();
            Console.WriteLine("digite a idade");
            idade3 = int.Parse(Console.ReadLine());

            if (idade1 > idade2 && idade1 > idade3)
            {
                Console.WriteLine("O " + nome1 + " é o mais velho com" + idade1 + " anos");
            }
            else if (idade2 > idade1 && idade2 > idade3)
            {
                Console.WriteLine("O " + nome2 + " é o mais velho com" + idade2 + " anos");
            }
            else
            {
                Console.WriteLine("O " + nome3 + " é o mais velho com" + idade3 + " anos");
            }
        }
    }
}
