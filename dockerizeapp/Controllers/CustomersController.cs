using dockerizeapp.Models;
using dockerizeapp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dockerizeapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly CustomersRepository _repository;

        public CustomersController(CustomersRepository repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// My Comment New App
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Customer> Get() => _repository.GetCustomers();
         
    }
}
