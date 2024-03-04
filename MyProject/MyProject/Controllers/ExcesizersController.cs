using Bl.BlModels;
using Bl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bl.BlApi;

namespace MyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcesizersController : ControllerBase
    {
        IBlExcersizers excersizer;
        public ExcesizersController(BLManager bl)
        {
            this.excersizer = bl.Excersizers;
        }

        [HttpGet]
        public ActionResult<List<BlExcersizer>> Get()
        {
            if(excersizer.GetAll() != null)
            {
                return Ok(excersizer.GetAll());
            }
            return BadRequest();
            //return Ok(contexr.GetAll());
        }

        [HttpGet("{Id}")]
        public ActionResult<BlExcersizer> GetById(int Id)
        {
            if(Id == null)
                return BadRequest();
            return Ok(excersizer.Get(Id));
        }

        [HttpPost]
        public ActionResult<BlExcersizer> Post(BlExcersizer bl)
        {
            if(bl == null)
                return BadRequest();
            return Ok(excersizer.Add(bl));
        }

    }
}
