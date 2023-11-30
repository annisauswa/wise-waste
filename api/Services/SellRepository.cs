using api.Models;

namespace api.Services
{
    public class SellRepository
    {
        private readonly Sell _context;

        public SellRepository(Sell context)
        {
            _context = context;
        }

        public List<Sell> GetAllSell()
        {
            return _context.Sells.ToList();
        }
    }
}
