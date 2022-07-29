using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(string initMessage = ""){
            Console.Clear();
            Console.Write(initMessage);
            Console.WriteLine($"Cronometro\n");
            Console.WriteLine("S - Segundos (10s)");
            Console.WriteLine("M - Minutos (10m)");
            Console.WriteLine("0 - Sair");

            Console.WriteLine($"\nInforme o tempo com o sufixo desejado:");
            string data = Console.ReadLine().ToLower();

            try{
                if (data == "0") System.Environment.Exit(0);
                int time = int.Parse(data.Substring(0, data.Length - 1));
                char type = char.Parse(data.Substring(data.Length - 1, 1));
                int multiplier = 1;

                if (type == 'm') multiplier = 60;
                if (time <= 0) System.Environment.Exit(0);

                Start(time*multiplier, data);
            }catch{
                Menu("Algo deu errado, tente novamente\n\n");
            }

            
        }
        static void Start(int time, string data){
            int currentTime = 0;

            while(currentTime != time){
                Console.Clear();
                Console.WriteLine($"Cronometro: {data}");
                Console.WriteLine($"{currentTime}/{time}s");
                currentTime++;
                Thread.Sleep(1000);
            }
            Menu("Stopwatch finalizado!\n\n");
        }
    }
}
