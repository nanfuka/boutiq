using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using boutiq.Models;

namespace boutiq.Data.Sales
{
    public interface ISalesInterface
    {
        Sale CreateSalesItem(Sale Sale);

        Sale UpdateSalesItems(Sale Sales);

        IEnumerable<Sale> GetAllSalesItems();
        Sale GetSalesItemsById(int id);
        // delete interface
        string DeleteSalesItem(Sale Sales);
    }
}
