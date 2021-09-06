using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using boutiq.Models;

namespace boutiq.Data
{
    public interface IStockInterface
    {
        Stock CreateStockItem(Stock Stock);

        Stock UpdateStockItems(Stock Stock);

        IEnumerable<Stock> GetAllStockItems();
        Stock GetStockItemsById(int id);
        // delete interface
        string DeleteStockItem(Stock Stock);
    }
}
