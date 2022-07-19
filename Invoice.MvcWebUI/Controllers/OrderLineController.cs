using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Invoice.Business.Abstract;
using Invoice.Entites.Concrete;
using Invoice.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Invoice.MvcWebUI.Controllers
{
    [ApiController]
    [Route("api/orderLine")]
    public class OrderLineController:Controller
    {
        private readonly IOrderLineService _orderLineService;
        private readonly IItemService _itemService;
        public OrderLineController(IOrderLineService orderLineService, IItemService itemService)
        {
            _orderLineService = orderLineService;
            _itemService = itemService;
        }

        [Route("getOrderLines")]
        [HttpGet]
        public ActionResult Index()
        {
            try
            {
                return Ok(_orderLineService.GetOrderLines());
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }

        [Route("deleteOrderLine")]
        [HttpPost]

        public ActionResult DeleteOrderLine([FromBody]OrderLine orderLine)
        {
            try
            {
                _orderLineService.Delete(orderLine);
                return Ok(_orderLineService.GetAll());
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }

        [Route("updateOrderLine")]
        [HttpPost]

        public ActionResult UpdateOrdeLine([FromBody]OrderLine orderLine)
        {
            try
            {
                _orderLineService.Update(orderLine);
                return Ok(_orderLineService.GetAll());
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }

        [Route("addOrderLine")]
        [HttpPost]

        public ActionResult AddOrderLine([FromBody]OrderLine orderLine)
        {
            try
            {
                _orderLineService.Add(orderLine);
                return Ok(_orderLineService.GetAll());
            }
            catch (Exception e)
            {
                try
                {
                    _orderLineService.Update(orderLine);
                    return Ok();
                }
                catch (Exception exception)
                {
                    return NotFound();
                }
            }
        }

        [Route("getOrderLinesAtFiche")]
        [HttpPost]

        public ActionResult GetOrderLinesAtFiche([FromBody]Orderfiche orderfiche)
        {
            try
            {
                List<OrderLine> orderLines = _orderLineService.GetAllByFicheId(orderfiche.Id);
                List<Item> orderLineItem = new List<Item>();
                for (int i = 0; i < orderLines.Count; i++)
                {
                    orderLineItem.Add(_itemService.GetById(orderLines[i].ItemId));
                }
                OrderLinesModel model = new OrderLinesModel
                {
                    orderLines = orderLines,
                    items = orderLineItem
                };
                return Ok(orderLines);
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
    }
}
