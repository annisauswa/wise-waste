using api.Models;
using api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellController : ControllerBase
    {
        private readonly SellRepository _sellRepository;

        public SellController(SellDbContext context)
        {
            _sellRepository = new SellRepository(context);
        }

        [HttpGet]
        public List<SellDbContext> Get()
        {
            return _sellRepository.GetAllSell();
        }
    }
}
