using System.Collections.Generic;
using boutiq.Models;

namespace boutiq.Data
{
    public interface IBoutiqInterface
    {
        IEnumerable<Boutiq> GetAllBoutiqItems();
        Boutiq GetBoutiqItemsById(int id);

    }
}