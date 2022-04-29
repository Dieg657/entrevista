using System;
using System.Linq;
using System.Text;

namespace TesteNeon
{
    /*
     * Receber um texto um texto e verificar se o mesmo é palíndromo, e retornar 1 (true) se palíndromo, e 0 (false) se não for
     */ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("É palindromo? {0}", IsPalindromo("2002"));
            Console.WriteLine("É palindromo? {0}", IsPalindromo("amoraroma"));
        }

        public static bool IsPalindromo(string texto)
        {
            //2002 - 4
            //alala - 5 
            //amoraroma - 9
            //ala - 3

            var esquerda = texto.Substring(0, (texto.Length / 2));

            var arrayInvertido = texto.ToArray();

            Array.Reverse(arrayInvertido);

            var textoInvertido = new string(arrayInvertido);

            var direita = textoInvertido.Substring(0, (textoInvertido.Length / 2));

            return direita == esquerda;
        }
    }
}
