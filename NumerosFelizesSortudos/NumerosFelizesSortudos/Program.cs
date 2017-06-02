using System;
using NumerosFelizesSortudos;

namespace NumerosFelizesSortudos
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Informe um número!");
                string input = Console.ReadLine();
                int n;
                while (!int.TryParse(input, out n))
                {
                    Console.WriteLine("Favor informe um número inteiro entre 0  e 9.999.999");
                    input = Console.ReadLine();
                }

                Console.WriteLine(string.Format("{0} - Número {1} e {2}", n, (n.isLucky() ? "Sortudo" : "Não-Sortudo"), (n.isHappy() ? "Feliz" : "Não-Feliz")));
            }
        }
    }
}
