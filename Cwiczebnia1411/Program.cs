using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczebnia1411
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba("Jan", "Kowalski");
            Student student1 = new Student("Abba", "Nowa", 2, 3, 12321);
            osoba1.WypiszInfo();
            student1.WypiszInfo();

            Osoba student2 = new Student("Lukasz","ZAK",2,3,12313);

            student2.WypiszInfo();
            
            
            Console.ReadKey();
        }
    }
}
