using System;
using System.Collections.Generic;

namespace JewelryFactoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Налаштування коректного відображення українських символів у консолі
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Демонстрація роботи з категорією "Золото"
            Console.WriteLine("=== КАТАЛОГ: ЗОЛОТО ===");
            IJewelryFactory goldFactory = new GoldFactory();
            RunCatalog(goldFactory);

            Console.WriteLine("\n=== КАТАЛОГ: СРІБЛО ===");
            IJewelryFactory silverFactory = new SilverFactory();
            RunCatalog(silverFactory);

            Console.ReadKey();
        }

        static void RunCatalog(IJewelryFactory factory)
        {
            List<JewelryItem> catalog = new List<JewelryItem>
            {
                factory.CreateEarring(5.5, 1.2),
                factory.CreateRing(3.0, 1.5),
                factory.CreateNecklace(10.0, 1.1),
                factory.CreatePendant(2.5, 1.3),
                factory.CreateBracelet(8.0, 1.4)
            };

            foreach (var item in catalog)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}