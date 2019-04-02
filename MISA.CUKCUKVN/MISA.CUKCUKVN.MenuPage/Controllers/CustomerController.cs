﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MISA.CUKCUKVN.MenuPage.Models;

namespace MISA.CUKCUKVN.MenuPage.Controllers
{
    [Route("api/Customer/[action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET api/Customer
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return Customer.customers;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
