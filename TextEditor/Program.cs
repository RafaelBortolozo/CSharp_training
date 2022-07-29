using System;
using System.IO;

namespace TextEditor
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
            Console.WriteLine($"Editor de texto\n\n");
            Console.WriteLine("1 - Abrir Arquivo text.txt");
            Console.WriteLine("2 - Criar Novo Arquivo text.txt");
            Console.WriteLine("0 - Sair");

            Console.WriteLine($"\nDigite uma opção:");
            short opt = short.Parse(Console.ReadLine());

            switch(opt){
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: 
                    Menu("Opção inválida, tente novamente\n\n"); 
                    break;
            }

        }

        static void Abrir(){
            Console.Clear();
            string path = Directory.GetCurrentDirectory() + "\\text.txt";

            using (var file = new StreamReader(path)){
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.ReadLine();
            Menu();
        }

        static void Editar(){
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("----------------");
            string text = "";

            do{
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);
        }

        static void Salvar(string text){
            Console.Clear();

            string path = Directory.GetCurrentDirectory() + "\\text.txt";

            using(var file = new StreamWriter(path)){
                file.Write(text);
            }

            Menu($"Arquivo text.txt salvo com sucesso\n\n");
        }
    }
}
