using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wise_waste
{
    internal class TransactionHistory
    {
        public string Category { get; private set; }
        public int Weight { get; private set; }
        public int Price { get; private set; }
        public string Address { get; private set; }

        public TransactionHistory(string category, int weight, int price, string address)
        {
            Category = category;
            Weight = weight;
            Price = price;
            Address = address;
        }

        public void ShowTransactionHistory()
        {
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Address: {Address}");
        }
    }
}
