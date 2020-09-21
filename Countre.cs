using Amazon.DynamoDBv2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen2._0
{
    public class Countre
    {

        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }

        public City City { get; set; }
        
        public List<vetka> vetki;
        public void registr()
        {
            Console.WriteLine("Введите название страны!");
            Name = Console.ReadLine();
        }
    }
}
