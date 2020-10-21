using boutiq.Data;
using boutiq.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace boutiqApi.Controllers
{
    [Route("api/boutiq")]
    [ApiController]
    public class BoutiqController : ControllerBase
    {

        private readonly IBoutiqInterface _repository;

        public BoutiqController(IBoutiqInterface repository)
        {
            _repository = repository;

        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public Boutiq PostBoutiqItem([FromBody] Boutiq boutiqItem)
        {
            var addedBoutiqItem = _repository.CreateBotiqItem(boutiqItem);
            return boutiqItem;
        }

        // http request for retrieving all items from the database
        [HttpGet]
        public ActionResult<IEnumerable<Boutiq>> GetAllBoutiqItems()
        {
            var BoutiqItems = _repository.GetAllBoutiqItems();
            return Ok(BoutiqItems);
        }
        // http request for retrieving a single item
        [HttpGet("{id}")]
        public ActionResult<Boutiq> GetBoutiqItemsById(int id)
        {
            var singleItem = _repository.GetBoutiqItemsById(id);

            if (singleItem == null)
            {
                return NotFound();

            }
            return Ok(singleItem);
        }
        // http request for modifying Iboutiq data
        [HttpPut]
        public Boutiq UpdateBoutiqItems([FromBody] Boutiq boutiq)

        {
            var updatedItem = _repository.UpdateBoutiqItems(boutiq);
            return updatedItem;
        }
        // http request for deleting a single Boutiq item
        [HttpDelete("{id}")]
        public string DeleteBoutiqItem(int id)
        {
            var itemToBeDeleted = _repository.GetBoutiqItemsById(id);
            if (itemToBeDeleted == null)
            {
                return "Boutic Item id is not found";

            }

            var deleteBoutiqItem = _repository.DeleteBoutiqItem(itemToBeDeleted);

            return "the item has need deleted";
        }
    }
}