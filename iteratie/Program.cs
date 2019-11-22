// Enrick De Munter 5ITN nr 4
// V1: 22/11/19

/*Demo herhalingsstructuren
 * 
 * 
 * 
 */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteratie
{
    class Program
    {
        static void Main(string[] args)
        {
            byte teller = 0;
            while (teller<100)
            {
                Console.WriteLine(teller);
                teller += 1 ;
            }
            



            //wachten
            Console.WriteLine();
            Console.WriteLine("druk op enter om af te sluiten");
            Console.ReadKey();
        }

    }
}
