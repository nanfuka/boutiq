using boutiq.Data;
using boutiq.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


namespace Stok.Controllers
{
    public class StockController : Controller
    {
        private readonly IStockInterface _repository;

        public StockController(IStockInterface repository)
        {
            _repository = repository;

        }

        [HttpPost]
        public Stock PostSaleItem([FromBody] Stock SaleItem)
        {
            var addedStockItem = _repository.CreateStockItem(SaleItem);
            return SaleItem;
        }


        // http request for retrieving all items from the database
        [HttpGet]
        public ActionResult<IEnumerable<Stock>> GetAllStockItems()
        {
            var StockItems = _repository.GetAllStockItems();
            return Ok(StockItems);
        }
        // http request for retrieving a single item
        [HttpGet("{id}")]
        public ActionResult<Stock> GetStockItemsById(int id)
        {
            var singleItem = _repository.GetStockItemsById(id);

            if (singleItem == null)
            {
                return NotFound();

            }
            return Ok(singleItem);
        }
        // http request for modifying IStock data
        [HttpPut]
        public Stock UpdateStockItems([FromBody] Stock Stock)

        {
            var updatedItem = _repository.UpdateStockItems(Stock);
            return updatedItem;
        }
        // http request for deleting a single Stock item
        [HttpDelete("{id}")]
        public string DeleteStockItem(int id)
        {
            var itemToBeDeleted = _repository.GetStockItemsById(id);
            if (itemToBeDeleted == null)
            {
                return "Boutic Item id is not found";

            }

            var deleteStockItem = _repository.DeleteStockItem(itemToBeDeleted);

            return "the item has been deleted";
        }
    }
}
