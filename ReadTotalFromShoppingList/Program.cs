using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ReadTotalFromShoppingList
{
    class Program
    {
        public class Item
        {
            string name;
            int price;
            public Item(string _name, int _price)
            {
                name = _name;
                price = _price;
            }
            public string Name { get { return name; } }
            public int Price { get { return price; } }
        }
        static void Main(string[] args)
        {
            ReadFromShoppingList();
        }
        public static void ReadFromShoppingList()
        {
            string filePath = @"C:\Users\opilane\samples";
            string fileName = @"shoppingList.txt";
            List<Item> shoppingItem = new List<Item>();
            List<string> linesfromFile = File.ReadAllLines(Path.Combine(filePath, fileName)).ToList();
            foreach(string line in linesfromFile)
            {
                Console.WriteLine(line);
            }
        }
    }
}
