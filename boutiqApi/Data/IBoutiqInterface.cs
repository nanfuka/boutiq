using System.Collections.Generic;
using boutiq.Models;

namespace boutiq.Data
{
    public interface IBoutiqInterface
    {
        Boutiq CreateBotiqItem(Boutiq boutiq);

        Boutiq UpdateBoutiqItems(Boutiq boutiq);

        IEnumerable<Boutiq> GetAllBoutiqItems();
        Boutiq GetBoutiqItemsById(int id);

    }
}