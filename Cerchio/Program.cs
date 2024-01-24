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
            c = null;
            Console.WriteLine(c);

            Console.ReadLine();
        }
    }
}
