using System.Collections.Generic;
using boutiq.Models;
using System.Linq;

namespace boutiq.Data
{
    public class SqlBoutiqRepo : IBoutiqInterface
    {
        private readonly BoutiqContext _context;

        public SqlBoutiqRepo(BoutiqContext context)
        {
            _context = context;
        }

        public Boutiq CreateBotiqItem(Boutiq boutiq)
        {
            // var boutique = new Boutiq();
            _context.Add<Boutiq>(boutiq);
            _context.SaveChanges();
            return boutiq;
        }

        IEnumerable<Boutiq> IBoutiqInterface.GetAllBoutiqItems()
        {
            return _context.Boutiqs.ToList();
        }

        Boutiq IBoutiqInterface.GetBoutiqItemsById(int id)
        {
            return _context.Boutiqs.FirstOrDefault(p => p.Id == id);
        }


    }
}

