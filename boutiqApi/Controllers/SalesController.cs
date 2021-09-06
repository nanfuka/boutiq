using boutiq.Data.Sales;
using boutiq.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace boutiq.Controllers
{
    public class SalesController : Controller
    {
        private readonly ISalesInterface _repository;

        public SalesController(ISalesInterface repository)
        {
            _repository = repository;

        }


        [HttpPost]
        public Sale PostSaleItem([FromBody] Sale SaleItem)
        {
            var addedSaleItem = _repository.CreateSalesItem(SaleItem);
            return SaleItem;
        }

        // http request for retrieving all items from the database
        [HttpGet]
        public ActionResult<IEnumerable<Sale>> GetAllSaleItems()
        {
            var SaleItems = _repository.GetAllSalesItems();
            return Ok(SaleItems);
        }
        // http request for retrieving a single item
        [HttpGet("{id}")]
        public ActionResult<Sale> GetSaleItemsById(int id)
        {
            var singleItem = _repository.GetSalesItemsById(id);

            if (singleItem == null)
            {
                return NotFound();

            }
            return Ok(singleItem);
        }
        // http request for modifying ISale data
        [HttpPut]
        public Sale UpdateSaleItems([FromBody] Sale Sale)

        {
            var updatedItem = _repository.UpdateSalesItems(Sale);
            return updatedItem;
        }
        // http request for deleting a single Sale item
        [HttpDelete("{id}")]
        public string DeleteSaleItem(int id)
        {
            var itemToBeDeleted = _repository.GetSalesItemsById(id);
            if (itemToBeDeleted == null)
            {
                return "Boutic Item id is not found";

            }

            var deleteSaleItem = _repository.DeleteSalesItem(itemToBeDeleted);

            return "the item has been deleted";
        }
    }
}

