using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Menu();

            //Soma();
            //Subtracao();
            //Multiplicacao();
            //Divisao();
        }

        static void Menu(string statusMessage = ""){
            Console.Clear();

            Console.Write(statusMessage);
            Console.WriteLine($"Calculadora\n");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            Console.WriteLine($"\nDigite uma opção:");
            short opt = short.Parse(Console.ReadLine());

            switch(opt){
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default:
                    Menu("Opção invalida, tente novamente\n\n");
                    break;
            }
        }

        static void Soma(){
            Console.Clear();
            
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());
            
            float resultado = v1 + v2;
            Console.WriteLine($"\nO resultado da soma é {resultado}");
            Console.WriteLine($"Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao(){
            Console.Clear();
            
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());
            
            float resultado = v1 - v2;
            Console.WriteLine($"\nO resultado da subtração é {resultado}");
            Console.WriteLine($"Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao(){
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());
            
            float resultado = v1 * v2;
            Console.WriteLine($"\nO resultado da multiplicacao é {resultado}");
            Console.WriteLine($"Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Menu();
        }

        static void Divisao(){
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;
            Console.WriteLine($"\nO resultado da divisao é {resultado}");
            Console.WriteLine($"Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Menu();
        }
    }
}
