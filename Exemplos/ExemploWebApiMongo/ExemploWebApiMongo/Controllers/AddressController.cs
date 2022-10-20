﻿using ExemploWebApiMongo.Models;
using ExemploWebApiMongo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver.Linq;
using System.Collections.Generic;
using System.Linq;

namespace ExemploWebApiMongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly AddressServices _addressServices;
        private readonly ClientServices _clientServices;

        public AddressController(AddressServices addressServices, ClientServices clientServices)
        {
            _addressServices = addressServices;
            _clientServices = clientServices;
        }

        [HttpGet]
        public ActionResult<List<Address>> Get() => _addressServices.Get();

        [HttpGet("{id:length(24)}", Name = "GetAddress")]
        public ActionResult<Address> Get(string id)
        {            
            var address = _addressServices.Get(id);

            if (address == null)
            {
                return NotFound();
            }
            return address;
        }

        [HttpPost]
        public ActionResult<Address> Create(Address address)
        {
            _addressServices.Create(address);
            return CreatedAtRoute("GetAddress", new { id = address.Id.ToString() }, address);
        }

        [HttpPut]
        public ActionResult<Address> Update(string id, Address addressIn)
        {
            var address = _addressServices.Get(id);

            if (address == null)
            {
                return NotFound();
            }

            addressIn.Id = id;

            _addressServices.Update(id, addressIn);

            return CreatedAtRoute("GetAddress", new { id = addressIn.Id.ToString() }, addressIn);
        }

        [HttpDelete]
        public ActionResult Remove(string id)
        {
            var address = _addressServices.Get(id);

            if (address == null)
            {
                return NotFound();
            }

            _addressServices.Remove(address);

            return NoContent();
        }

    }
}
