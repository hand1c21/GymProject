using Bl.BlModels;
using Bl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bl.BlApi;
//using Dal.DalApi;

namespace MyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcesizersController : ControllerBase
    {
        IExcersizers excersizer;
        public ExcesizersController(BLManager bl)
        {
            this.excersizer = bl.Excersizers;
        }
        //IExcersizers contexr;

        [HttpGet]
        public ActionResult<List<Excersizer>> Get()
        {
            if(excersizer.GetAll() != null)
            {
                return Ok(excersizer.GetAll());
            }
            return BadRequest();
            //return Ok(contexr.GetAll());
        }
    }
}
