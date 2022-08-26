using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using AWSproject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWSproject.Services;

namespace AWSproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IRepo<int, Customer> _repo;

        public CustomerController(IRepo<int, Customer> repo)
        {
            _repo = repo;
        }

        public async Task<ActionResult<List<Customer>>> Get()
        {
            return Ok((await _repo.GetAll()).ToList());
        }
    }
}
