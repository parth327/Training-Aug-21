using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToyCompanyApi.Models;
using ToyCompanyApi.Repository;

namespace ToyCompanyApi.Controllers
{
    [Route("api/{customerId}/Orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IToyCompanyRepository _toyCompanyRepository;
        private readonly IMapper _mapper;

        public OrderController(IToyCompanyRepository toyCompanyRepository, IMapper mapper)
        {
            _toyCompanyRepository = toyCompanyRepository ??
                throw new ArgumentNullException(nameof(toyCompanyRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public ActionResult<IEnumerable<OrderHeaders>> GetOrders(int customerId)
        {
            var Orders = _toyCompanyRepository.GetOrders(customerId);

            if (Orders == null)
            {
                return BadRequest();
            }
            return Ok(Orders);
        }
    }
}

