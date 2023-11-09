using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wise_waste
{
    internal class Sell
    {
        private int sell_id;
        private int category_id;
        private int weight;
        private int amount;

        public int Sell_ID
        {
            get { return sell_id; }
            set { sell_id = value; }
        }
        public int Category_ID
        {
            get {  return category_id; }
            set { category_id = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public Sell(int category_id, int weight)
        {
            Category_ID = category_id;
            Weight = weight;
        }
        protected virtual int CalculateAmount(int Category_ID, int Weight)
        {
            // Default implementation for calculating amount
            Amount = 0;
            return Amount;
        }

    }
    internal abstract class CalculateSell : Sell
    {
        public CalculateSell(int category_id, int weight) : base(category_id, weight)
        {
        }
        public override int CalculateAmount(int Category_ID, int Weight)
        {
            int price = 0;
            if (Category_ID == 1)
                price = 15000;
            else if (Category_ID == 2)
                price = 9000;
            else if (Category_ID == 3)
                price = 12500;
            else
            {
                throw new InvalidOperationException("Unsupported Category_ID");
            }

            Amount = price * Weight;
            return Amount;
        }
    }

}
