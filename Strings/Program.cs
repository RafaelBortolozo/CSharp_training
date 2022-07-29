using System;
using System.Linq;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // GUID

            // var id = Guid.NewGuid(); //id unico
            // id.ToString();
            // Console.WriteLine(id);
            // id = new Guid("8688615a-d378-4847-9c73-a0b0333ed53d"); //converte string pra Grid
            // Console.WriteLine(id);


            /***************************************************************/
            // INTERPOLAÇÃO DE STRINGS

            //var price = 10.2;
            //var texto = "O preço do produto é " + price + " apenas na promoção";
            //var texto = string.Format("O preço do produto é {0} apenas na {1}", price, "promoção");
            //var texto = $"O preço do produto é {price} apenas na promoção";
            //var texto = $@"O preço do 
            //                produto é {price} 
            //                apenas na promoção";
            //Console.WriteLine(texto);


            /***************************************************************/
            // COMPARAÇÃO DE STRINGS

            // var texto = "texto teste";
            // Console.WriteLine("CompareTo (igualdade): " + texto.CompareTo("Teste"));
            // Console.WriteLine("Contains (contem): " + texto.Contains("Teste"));
            // Console.WriteLine("Contains (contem com ignoreCase): " + texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));


            /***************************************************************/
            // STARTSWITH/ENDSWITH

            // var texto = "Este texto é um teste";
            // Console.WriteLine($"Texto: {texto}");
            // Console.WriteLine("startsWith (este): " + texto.StartsWith("este"));
            // Console.WriteLine("startsWith ignorecase (este): " + texto.StartsWith("este", StringComparison.OrdinalIgnoreCase));
            // Console.WriteLine("EndsWith (Teste): " + texto.EndsWith("Teste"));
            // Console.WriteLine("EndsWith ignorecase (Teste): " + texto.EndsWith("Teste", StringComparison.OrdinalIgnoreCase));


            /***************************************************************/
            // EQUALS (funciona com outros tipos tbm)

            // var texto = "Este texto é um teste";
            // Console.WriteLine($"Texto: {texto}");
            // Console.WriteLine("equals (Este texto é um teste): " + texto.Equals("Este texto é um teste"));
            // Console.WriteLine("equals (este texto é um teste): " + texto.Equals("este texto é um teste"));
            // Console.WriteLine("equals (este texto é um teste): " + texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));
            

            /***************************************************************/
            // INDEX

            // var texto = "Este texto é um teste";
            // Console.WriteLine($"Texto: {texto}");
            // Console.WriteLine("indexOf (é): " + texto.IndexOf("é")); //primeira ocorrencia
            // Console.WriteLine("lastIndexOf (s): " + texto.LastIndexOf("s")); //ultima ocorrencia


            /***************************************************************/
            // METODOS ADICIONAIS

            // var texto = "Este texto é um teste";
            // Console.WriteLine($"Texto: {texto}");
            // Console.WriteLine("Maiusculo: " + texto.ToUpper());
            // Console.WriteLine("Minusculo: " + texto.ToLower());
            // Console.WriteLine("Adicionando (AQUI): " + texto.Insert(5,"AQUI "));
            // Console.WriteLine("Removendo (AQUI): " + texto.Remove(5, 5)); //inicio, remove 5 caracteres
            // Console.WriteLine("Tamanho: " + texto.Length);


            /***************************************************************/
            // MANIPULANDO STRINGS

            // var texto = " Este texto é um teste ";
            // Console.WriteLine($"Texto: {texto}");
            // Console.WriteLine("Replace (e, X): " + texto.Replace("e", "X")); //substitui todos
            // Console.WriteLine("Split (separado e juntado): " + string.Join(", ", texto.Split("")));
            // Console.WriteLine("Substring (5, 5): " + texto.Substring(5, 5)); //apartir de 5 pegue 5
            // Console.WriteLine("trim (sem espaço no começo-fim): " + texto.Trim());


            /***************************************************************/
            // STRING BUILDER 
            // Com ele podemos concatenar varias string (seria com +=) sem criar várias copias na memoria, além de outras funções

            var texto = new StringBuilder();
            texto.Append("Este texto é um teste ");
            texto.Append("É um teste ");
            texto.Append("abuabuabau ");
            texto.Append("qualquer outra coisa");
            Console.WriteLine("Stringbuilder: " + texto); //Precisa converter pra string, .ToString()
        }
    }
}
