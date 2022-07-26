using System;

namespace teste1
{
    struct Product{

        public Product(int id, string name, double price, EProductType type){
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }
        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;
        public double PriceInDolar(double dolar){
            return Price * dolar;
        }
    }

    enum EProductType{
        Product = 1,
        Service = 2
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            int inteiro = 100;
            float real = 25.5f;
            
            real = inteiro;
            inteiro = (int)real;
            inteiro = int.Parse(real.ToString());
            inteiro = Convert.ToInt32(real);
            */
            var mouse = new Product(1, "Mouse Gamer", 299.97, EProductType.Product);
            

            Console.WriteLine(mouse);

        }
    }
}
