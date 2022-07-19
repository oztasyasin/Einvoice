using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Invoice.Business.Abstract;
using Invoice.Entites.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Invoice.MvcWebUI.Controllers
{
    [Route("api/client")]
    [ApiController]
    public class ClientController:Controller
    {
        private readonly IClientService _clientService;
        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [Route("getClients")]
        [HttpGet]
        public ActionResult Index()
        {
            try
            {
                return Ok(_clientService.GetAll());
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
        [Route("addClient")]
        [HttpPost]
        public ActionResult AddClient([FromBody]Client client)
        {
            try
            {
                _clientService.Add(client);
                return Ok(_clientService.GetAll());
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
        [Route("deleteClient")]
        [HttpPost]
        public ActionResult DeleteClient([FromBody]Client client)
        {
            try
            {
                _clientService.Delete(client);
                return Ok(_clientService.GetAll());
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }

        [Route("updateClient")]
        [HttpPost]
        public ActionResult UpdateClient([FromBody]Client client)
        {
            try
            {
                _clientService.Update(client);
                return Ok(_clientService.GetAll());
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
    }
}
