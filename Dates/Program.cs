using System;
using System.Globalization;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            /************************************************/
            // DATA ESPECIFICA
            // var date = new DateTime(2020, 10, 12, 8, 23, 14);
            // var currentDate = DateTime.Now;
            // Console.WriteLine($"{date.Year} + {date.Month} + {date.Day} + {date.Hour} + {date.Minute} + {date.Second}");


            /************************************************/
            // FORMATANDO DATAS 
            
            // var date = DateTime.Now;
            // var formatada = string.Format("{0:yyyy}", date);
            // var formatada = string.Format("{0:M}", date);
            // var formatada = string.Format("{0:m}", date);
            // var formatada = string.Format("{0:dd-MM-yyyy hh:mm:ss}", date);
            // Console.WriteLine(formatada);


            /************************************************/
            // PADRÕES DE FORMATAÇÃO
            
            // var date = DateTime.Now;
            // var formatada = string.Format("{0:t}", date);
            // var formatada = string.Format("{0:g}", date);
            // Console.WriteLine(formatada);


            /************************************************/
            // ADICIONANDO VALORES
            
            // var date = DateTime.Now;
            // Console.WriteLine(date);
            // Console.WriteLine(date.AddDays(-12));
            // Console.WriteLine(date.AddMonths(1));
            // Console.WriteLine(date.AddYears(1));


            /************************************************/
            // COMPARANDO DATAS
            
            // var date = DateTime.Now;

            // if (date.Date == DateTime.Now.Date){ //Não compare os objetos
            //     Console.WriteLine("É igual");
            // }

            // Console.WriteLine(date);


            /************************************************/
            // CULTUREINFO
            
            // var pt = new CultureInfo("pt-PT");
            // var br = new CultureInfo("pt-BR");
            // var en = new CultureInfo("en-US");
            // var de = new CultureInfo("de-DE");
            // var atual = CultureInfo.CurrentCulture;

            // Console.WriteLine(DateTime.Now.ToString("D", atual));


            /************************************************/
            // TIMEZONE
            
            // var dateTime = DateTime.UtcNow; //corrige o tempo para o seu fuso horario
            // Console.WriteLine(dateTime);

            // var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Australia");
            // Console.WriteLine(timezoneAustralia);


            /************************************************/
            // TIMESPAN
            
            Console.Clear();

            var timeSpan = new TimeSpan(); 
            Console.WriteLine(timeSpan);

            var timeSpanNanoSegundos = new TimeSpan(1);
            Console.WriteLine(timeSpanNanoSegundos);

            var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
            Console.WriteLine(timeSpanHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
            Console.WriteLine(timeSpanHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundoMilisegundo = new TimeSpan(15, 3, 5, 50, 10);
            Console.WriteLine(timeSpanHoraMinutoSegundo);

            Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));
        }
    }
}
