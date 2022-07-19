using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Invoice.Business.Abstract;
using Invoice.Entites.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Invoice.MvcWebUI.Controllers
{
    [ApiController]
    [Route("api/orderfiche")]
    public class OrderficheController:Controller
    {
        private readonly IOrderficheService _orderficheService;
        private readonly IOrderLineService _orderLineService;

        public OrderficheController(IOrderficheService orderficheService, IOrderLineService orderLineService)
        {
            _orderficheService = orderficheService;
            _orderLineService = orderLineService;
        }
        [Route("getOrderfiches")]
        [HttpGet]
        public ActionResult Index()
        {
            try
            {
                return Ok(_orderficheService.GetAll());
            }
            catch (Exception e)
            {
                return NotFound();
                
            }
        }
        [Route("addOrderfiche")]
        [HttpPost]

        public ActionResult AddOrderFiche([FromBody]Orderfiche orderfiche)
        {
            try
            {
                _orderficheService.Add(orderfiche);
                Orderfiche orderfiche2 = _orderficheService.GetByFicheNo(orderfiche.ficheNo);
                return Ok(orderfiche2);
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
        [Route("deleteOrderfiche")]
        [HttpPost]

        public ActionResult DeleteOrdefiche([FromBody]Orderfiche orderfiche)
        {
            try
            {
                _orderficheService.Delete(orderfiche);
                return Ok(_orderficheService.GetAll());
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }

        [Route("updateOrderfiche")]
        [HttpPost]

        public ActionResult UpdateOrdefiche([FromBody]Orderfiche orderfiche)
        {
            try
            {
                _orderficheService.Update(orderfiche);
                return Ok(_orderficheService.GetAll());
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
        [Route("getOrderfiche")]
        [HttpPost]

        public ActionResult GetOrderFiche([FromBody]Orderfiche orderfiche)
        {
            try
            {
                return Ok(_orderficheService.GetById(orderfiche.Id));
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
    }
}
