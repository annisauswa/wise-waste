using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wise_waste
{
    internal class Catalogue
    {
        public char Id;
        public string category;
        public int price;
        //the input for the attributes supposed to be taken from database

        public void ShowCatalogue()
        {
            // we haven't design our UI, so we suppose we just write it onto console
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Category {category}");
            Console.WriteLine($"Price {price}");
        }

        public void EditItem()
        {
            //advance edit method will be completed after it's connected to database
        }

        public void DeleteItem()
        {
            //advance delete method will be completed after it's connected to database
        }
    }
}
