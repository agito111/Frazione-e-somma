using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Frazione f = new Frazione(12,20);
            Console.WriteLine(f);
            Frazione f1;
            f1 = Frazione.Parse(f.ToString());
            Console.WriteLine(f1);
            Frazione f3 = new Frazione(12, 20);
            f= f.Somma(f3);
            Console.WriteLine(f);
            Console.ReadLine();
        }
    }
}
