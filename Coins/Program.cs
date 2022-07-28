using System;
using System.Globalization;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            decimal valor = 10536.25m; //alta precisão
            Console.WriteLine(valor.ToString("C" ,CultureInfo.CreateSpecificCulture("pt-BR"))); // imprime em reais
            
            Console.WriteLine(Math.Round(valor)); //arredonda
            Console.WriteLine(Math.Ceiling(valor)); //arredonda pra cima
            Console.WriteLine(Math.Floor(valor)); //arredonda pra baixo

        }
    }
}
