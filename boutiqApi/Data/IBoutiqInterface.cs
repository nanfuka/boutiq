using boutiq.Models;
using System.Collections.Generic;


namespace boutiq.Data
{
    public interface IBoutiqInterface
    {
        Boutiq CreateBotiqItem(Boutiq boutiq);

        Boutiq UpdateBoutiqItems(Boutiq boutiq);

        IEnumerable<Boutiq> GetAllBoutiqItems();
        Boutiq GetBoutiqItemsById(int id);
        // delete interface
        string DeleteBoutiqItem(Boutiq boutiq);


    }
}