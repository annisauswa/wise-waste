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
        protected int category_id;
        protected int weight;
        private int amount;

        public int Sell_ID
        {
            get { return sell_id; }
            set { sell_id = value; }
        }
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public Sell(int category_id, int weight)
        {
            this.category_id = category_id;
            this.weight = weight;
        }
        public virtual int CalculateAmount()
        {
            Amount = 0;
            return Amount;
        }

    }
    internal abstract class CalculateSell : Sell
    {
        public CalculateSell(int category_id, int weight) : base(category_id, weight)
        {
        }
        public override int CalculateAmount()
        {
            int price = 0;
            if (category_id == 1)
                price = 15000;
            else if (category_id == 2)
                price = 9000;
            else if (category_id == 3)
                price = 12500;
            else
            {
                throw new InvalidOperationException("Unsupported Category_ID");
            }

            Amount = price * weight;
            return Amount;
        }
    }

}
