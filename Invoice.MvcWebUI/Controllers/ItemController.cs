using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Invoice.Business.Abstract;
using Invoice.Entites.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Invoice.MvcWebUI.Controllers
{
    [Route("api/item")]
    [ApiController]
    public class ItemController : Controller
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }
        [Route("getItems")]
        [HttpGet]
        public ActionResult Index()
        {
            try
            {
                return Ok(_itemService.GetAll());
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }

        [Route("addItem")]
        [HttpPost]
        public ActionResult AddNewItem([FromBody]Item item)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _itemService.Add(item);
                    return Ok(_itemService.GetAll());
                }
                catch (Exception e)
                {
                    return NotFound();
                }
            }
            else
            {
                return NotFound();
            }
        }

        [Route("deleteItem")]
        [HttpPost]

        public ActionResult DeleteItem([FromBody]Item item)
        {
            try
            {
                _itemService.Delete(item);
                return Ok(_itemService.GetAll());
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }

        [Route("updateItem")]
        [HttpPost]

        public ActionResult UpdateItem([FromBody]Item item)
        {
            try
            {
                _itemService.Update(item);
                return Ok(_itemService.GetAll());
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
    }
}
