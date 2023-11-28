using Microsoft.EntityFrameworkCore;

namespace api.Models
{
    public class SellDbContext : DbContext
    {
        public int sell_id { get; set; }
        public int category_id { get; set; }
        public string prod_name { get; set; }
        public int amount { get; set; }
        public int register_id { get; set; }

        public SellDbContext(int id, int cat_id, string name, int amount, int reg_id)
        {
            this.sell_id = id;
            this.category_id = cat_id;
            this.prod_name = name;
            this.amount = amount;
            this.register_id= reg_id;
        }

        public DbSet<SellDbContext> Sells { get; set; }

        public SellDbContext(DbContextOptions<SellDbContext> options)
            : base(options)
        {
        }
    }
}
