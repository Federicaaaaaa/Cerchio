using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerchio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cerchio c = new Cerchio();
            c.Raggio = float.Parse(Console.ReadLine());

            Console.WriteLine("Area: {0}", c.AreaCerchio());
            Console.WriteLine("Circonferenza: {0}", c.Circonferenza());
            //se c = null;
            //allora con Console.WriteLine(c) non stampa niente e non dà errore
            Console.WriteLine(c);

            Cerchio cparse;
            cparse = Cerchio.Parse(c.ToString());
            Console.WriteLine(cparse);

            Console.ReadLine();
        }
    }
}
