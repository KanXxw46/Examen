using System;

namespace Examen2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Countre countre = new Countre();
            Countre.vetki = new List<vetka>();
            vetka vetka = new vetka();
            char s;
            char x;
            do
            {
                Console.WriteLine();
                Console.WriteLine("***********************************************************");
                Console.WriteLine("* 0 - Выход                                               *");
                Console.WriteLine("* 1 - Добавить страну                                     *");
                Console.WriteLine("* 2 - Добавить город                                      *");
                Console.WriteLine("* 3 - Изменить данные                                     *");
                Console.WriteLine("* 4 - Вывести страны и города                             *");
                Console.WriteLine("***********************************************************");
                Console.WriteLine();
                Console.Write("Komanda:> ");
                x = Console.ReadKey().KeyChar;
                Console.WriteLine();
                s = x;
                switch (x)
                {
                    case '0':
                        break;
                    case '1':
                        rajons = new Rajons();
                        rajons.registr();
                        Countre.vetki.Add(vetka);
                        break;
                    case '2':
                        Console.WriteLine("Введите индекс Сраны!");
                        int index = Convert.ToInt32(Console.ReadLine());
                        rajons = new Rajons();
                        rajons.registr2();
                        vetka.vetki.Add(vetka);
                        break;
                    case '3':
                        break;
                    case '4':
                        Countre.vetka();
                        break;
                    default:
                        Console.WriteLine("Такого действия нет!");
                        break;
                }
            } while (s != '0');
        }

    }
    }
    
}
