using Bl;
using Bl.BlApi;
using Bl.BlModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainersController : ControllerBase
    {
        IBlTrainers trainers;
        public TrainersController(BLManager bl)
        {
            this.trainers = bl.Trainers;
        }
        //IExcersizers contexr;

        [HttpGet]
        public ActionResult<List<BlTrainer>> Get()
        {
            if (trainers.GetAll() != null)
            {
                return Ok(trainers.GetAll());
            }
            return BadRequest();
        }
    }
}
