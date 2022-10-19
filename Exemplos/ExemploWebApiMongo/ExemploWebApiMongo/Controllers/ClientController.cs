using ExemploWebApiMongo.Models;
using ExemploWebApiMongo.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ExemploWebApiMongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly ClientServices _clientServices;

        public ClientController(ClientServices clientServices)
        {
            _clientServices = clientServices;
        }

        [HttpGet]
        public ActionResult<List<Client>> Get() => _clientServices.Get();

        [HttpGet("{id:length(24)}", Name = "GetClient")]
        public ActionResult<Client> Get(string id)
        {
            var cliente = _clientServices.Get(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return cliente;
        }

        [HttpPost]
        public ActionResult<Client> Create(Client client)
        {
            _clientServices.Create(client);
            return CreatedAtRoute("GetClient", new { id = client.Id.ToString() }, client);
        }

        [HttpPut]
        public ActionResult<Client> Update(string id, Client clientIn)
        {
            var client = _clientServices.Get(id);

            if (client == null)
            {
                return NotFound();
            }

            clientIn.Id = id;

            _clientServices.Update(id, clientIn);

            return CreatedAtRoute("GetClient", new { id = clientIn.Id.ToString() }, clientIn);
        }

        [HttpDelete]
        public ActionResult Remove(string id)
        {
            var client = _clientServices.Get(id);

            if (client == null)
            {
                return NotFound();
            }

            _clientServices.Remove(client);

            return NoContent();
        }
    }
}
