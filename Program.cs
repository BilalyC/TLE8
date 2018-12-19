using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo8
{
    class Program
    {
        enum week
        {
            Lundi = 1,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }

        static void Main(string[] args)
        {
            week lundi = week.Lundi;
            week mardi = week.Mardi;
            week mercredi = week.Mercredi;
            week jeudi = week.Jeudi;
            week vendredi = week.Vendredi;
            week samedi = week.Samedi;
            week dimanche = week.Dimanche;
            Console.WriteLine(lundi);
            Console.WriteLine(mardi);
            Console.WriteLine(mercredi);
            Console.WriteLine(jeudi);
            Console.WriteLine(vendredi);
            Console.WriteLine(samedi);
            Console.WriteLine(dimanche);
            
            Console.WriteLine((week)4); //Console.WriteLine(Enum.GetName(typeof(week),4));
        }
    }
}
