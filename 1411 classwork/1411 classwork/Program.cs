using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1411_classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car("mazda");
            Car car3 = new Car("volvo", 1999, "purple", 1.8f, true);

            Console.WriteLine(car1);
            Console.WriteLine(car2);
            Console.WriteLine(car3);
        }
    }
}
