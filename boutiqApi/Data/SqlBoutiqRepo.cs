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