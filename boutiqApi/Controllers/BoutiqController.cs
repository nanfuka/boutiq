using boutiq.Data;
using boutiq.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace boutiq.Controllers
{
    [Route("api/boutiq")]
    [ApiController]
    public class BoutiqController : ControllerBase
    {

        private readonly IBoutiqInterface _repository;

        public BoutiqController(IBoutiqInterface repository)
        {
            _repository = repository;

        }


        [HttpPost]
        public Boutiq Index([FromBody] Boutiq person)
        {
            var addedBoutiqItem = _repository.CreateBotiqItem(person);
            return person;
        }

        [HttpGet]

        public ActionResult<IEnumerable<Boutiq>> GetAllBoutiqItems()
        {
            var BoutiqItems = _repository.GetAllBoutiqItems();
            return Ok(BoutiqItems);
        }

        [HttpGet("{id}")]
        public ActionResult<Boutiq> GetBoutiqItemsById(int id)
        {
            var singleItem = _repository.GetBoutiqItemsById(id);
            return Ok(singleItem);
        }


    }
}