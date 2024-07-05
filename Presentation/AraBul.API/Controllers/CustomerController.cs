using AraBul.Application.Repositories.ICustomerRepositories;
using AraBul.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AraBul.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        readonly private ICustomerWriteRepository _writeRepository;
        readonly private ICustomerReadRepository _readRepository;

        public CustomerController(ICustomerReadRepository readRepository, ICustomerWriteRepository writeRepository)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
         
            var list = await _readRepository.GetAllAsync();
            return Ok(list);
        }
    }
}
