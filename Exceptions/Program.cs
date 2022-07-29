using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {   
            // TRY/CATCH
            var arr = new int[3];
            try{
                // for(var i=0 ; i<10 ; i++){
                //     Console.WriteLine(arr[i]);
                // }

                Cadastrar("");
            }

            catch (IndexOutOfRangeException e){
                Console.WriteLine($"Erro: {e.Message}");
                Console.WriteLine($"Erro: Não encontrei o indice na lista");

            }

            catch (ArgumentNullException e){
                Console.WriteLine($"Erro: {e.Message}");
                Console.WriteLine($"Erro: Falha ao cadastrar texto");
            }

            catch (MinhaException e) {
                Console.WriteLine($"Erro: {e.Message}");
                Console.WriteLine($"Erro: {e.QuandoAconteceu}");
                Console.WriteLine($"Erro: exceção customizada");
            }
            
            catch (Exception e){
                Console.WriteLine("Deu ruim, tente novamente.");
                Console.WriteLine($"Erro: {e.Message}");
            }
            finally {
                Console.WriteLine("O finally sempre é executado, no final.");
            }
            
        }

        private static void Cadastrar(string texto){
            if (string.IsNullOrEmpty(texto)){
                throw new MinhaException(DateTime.Now);
            }
        }

        public class MinhaException : Exception { //herança de Exception
            public MinhaException(DateTime date){
                QuandoAconteceu = date;
            }

            public DateTime QuandoAconteceu { get; set;}
        }
    }
}
