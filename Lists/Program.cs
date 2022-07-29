using System;
using Internal;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // var meuArray = new int[5];
            // var meuArray = new int[5] {1, 2, 3, 4, 5};
            // Console.WriteLine(meuArray[0]);
            // meuArray[0] = 12;
            // Console.WriteLine(meuArray[0]);
            // Console.WriteLine(meuArray.Length);



            /*****************************************************/
            // PERCORRENDO UM ARRAY

            // var meuArray = new int[5] {1, 2, 3, 4, 5};
            // for (int i=0 ; i<meuArray.Length ; i++) {
            //     Console.WriteLine(meuArray[i]);
            // }



            /*****************************************************/
            // FOREACH

            var meuArray = new int[5] {1, 2, 3, 4, 5};
            foreach (var i in meuArray) {
                Console.WriteLine(meuArray[i]);
            }

        }
    }
}
