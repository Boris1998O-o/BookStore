using System.Collections.Generic;
using BookStore.BLL.Interfaces;
using BookStore.BLL.ViewModels.PrintingEditions;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IPrintingEditionService _printionEditionService;
        public ValuesController(IPrintingEditionService printionEditionService)
        {
            _printionEditionService = printionEditionService;
        }
        [HttpGet]
        public ActionResult<GetValuePrintingEditionViewModel> Get(int? id)
        {
            return _printionEditionService.PrintingFind(id);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
