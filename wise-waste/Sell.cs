using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wise_waste
{
    internal class Sell
    {
        public string Category { get; private set; }
        public int Weight { get; private set; }
        public int Price { get; private set; }
        public int Amount => Weight * Price;
        public string Address { get; private set; }

    // Define a constructor for user input
        public void SaleItem(string category, int weight, int price, string address)
        {
            Category = category;
            Weight = weight;
            Price = price;
            Address = address; // Taken from Profile database
        }

        public void confirmTransaction()
        {
            //show the data filled from database and ask for user confirmation
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Amount: {Amount}");
            Console.WriteLine($"Address {Address}");
        }

    }
}
