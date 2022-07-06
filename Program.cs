using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma palavra");
            string palavra = Console.ReadLine();

            string palavraAoContrario = string.Empty;

            var quantidadeDeCaracteres = palavra.Length;

            for(var contador = quantidadeDeCaracteres; contador >=1; contador--)
            {
                palavraAoContrario += palavra[contador - 1].ToString();
            }

            int eUmaPalavraPalindromo = 0;

            if (palavra.Equals(palavraAoContrario))
            {
                eUmaPalavraPalindromo = 1;

                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
