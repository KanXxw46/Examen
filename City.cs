using System;
using System.Collections.Generic;
using System.Text;

namespace Examen2._0
{
    public class City : Countre
    {
        public string Name { get; set; }
        public Countre Countre { get; set; }
        public string Capital { get; set; }
        public void registr2()
        {
            Console.WriteLine("Введите название города!");
            Name = Console.ReadLine();
        }
    }
}
