using boutiq.Data;
using boutiq.Data.Sales;
using boutiq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Data.Sales
{

    public class SqlSalesRepo : ISalesInterface
    {
        private readonly SalesContext _context;

        public SqlSalesRepo(SalesContext context)
        {
            _context = context;
        }
        // create
        public Sale CreateSalesItem(Sale Sales)
        {
            _context.Add<Sale>(Sales);
            _context.SaveChanges();
            return Sales;
        }

        // get
        IEnumerable<Sale> ISalesInterface.GetAllSalesItems()
        {
            return _context.Sales.ToList();
        }
        // getbyId
        Sale ISalesInterface.GetSalesItemsById(int id)
        {
            return _context.Sales.FirstOrDefault(p => p.Id == id);
        }

        // update
        public Sale UpdateSalesItems(Sale Sales)
        {
            _context.Sales.Update(Sales);
            _context.SaveChanges();
            return Sales;
        }

        public string DeleteSalesItem(Sale Sales)
        {
            _context.Sales.Remove(Sales);
            _context.SaveChanges();
            return "the Sales item has been deleted";


        }
    }
}