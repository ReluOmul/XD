using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XD_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("mustang", "blue", 1869, 220);
            Car Opel = new Car("astra", "red", 2020, 180);
            Car Volvo = new Car("xc90", "green", 2017, 200);
            /* Car Ford = new Car();
             Car Opel = new Car();
             Ford.name = "Mustang";
             Ford.year = 2021;
             Ford.color = "White";
             Ford.maxSpeed = 100;

             Opel.name = "Astra";
             Opel.color = "blue";
             Opel.year = 2020;
             Opel.maxSpeed = 120;*/


            Console.WriteLine(Ford.name);
            Console.WriteLine(Ford.year);
            Console.WriteLine(Ford.color);
            Ford.fullThrottle();

            Console.WriteLine(Opel.name);
            Console.WriteLine(Opel.color);
            Console.WriteLine(Opel.year);
            Opel.fullThrottle();
            Console.ReadKey();
        }
    }
}
