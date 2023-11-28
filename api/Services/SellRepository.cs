using api.Models;

namespace api.Services
{
    public class SellRepository
    {
        private readonly SellDbContext _context;

        public SellRepository(SellDbContext context)
        {
            _context = context;
        }

        public List<SellDbContext> GetAllSell()
        {
            return _context.Sells.ToList();
        }
    }
}
