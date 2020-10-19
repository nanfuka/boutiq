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
        // create
        public Boutiq CreateBotiqItem(Boutiq boutiq)
        {
            _context.Add<Boutiq>(boutiq);
            _context.SaveChanges();
            return boutiq;
        }

        // get
        IEnumerable<Boutiq> IBoutiqInterface.GetAllBoutiqItems()
        {
            return _context.Boutiqs.ToList();
        }
        // getbyId
        Boutiq IBoutiqInterface.GetBoutiqItemsById(int id)
        {
            return _context.Boutiqs.FirstOrDefault(p => p.Id == id);
        }

        // update
        public Boutiq UpdateBoutiqItems(Boutiq boutiq)
        {
            _context.Boutiqs.Update(boutiq);
            _context.SaveChanges();
            return boutiq;
        }

        public string DeleteBoutiqItem(Boutiq boutiq)
        {
            _context.Boutiqs.Remove(boutiq);
            _context.SaveChanges();
            return "the boutiq item has been deleted";


        }
    }
}

