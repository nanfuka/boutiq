using System.Collections.Generic;
using boutiq.Models;
using System.Linq;

namespace boutiq.Data
{
    public class SqlStockRepo : IStockInterface
    {
        private readonly StockContext _context;

        public SqlStockRepo(StockContext context)
        {
            _context = context;
        }
        // create
        public Stock CreateStockItem(Stock Stock)
        {
            _context.Add<Stock>(Stock);
            _context.SaveChanges();
            return Stock;
        }

        string IStockInterface.DeleteStockItem(Stock Stock)
        {
            _context.Stock.Remove(Stock);

            _context.SaveChanges();
            return "the Sales item has been deleted";
        }

        IEnumerable<Stock> IStockInterface.GetAllStockItems()
        {
            return _context.Stock.ToList();
        }

        Stock IStockInterface.GetStockItemsById(int id)
        {
            return _context.Stock.FirstOrDefault(p => p.Id == id);
        }


        public Stock UpdateStockItems(Stock Stock)
        {
            _context.Stock.Update(Stock);
            _context.SaveChanges();
            return Stock;
        }
    }
}

