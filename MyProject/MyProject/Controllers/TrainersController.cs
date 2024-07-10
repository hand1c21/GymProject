using Bl;
using Bl.BlApi;
using Bl.BlModels;
using Dal.DalApi;
using Dal.Models;
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

        [HttpGet]
        public ActionResult<List<BlTrainer>> Get()
        {
            if (trainers.GetAll() != null)
            {
                return Ok(trainers.GetAll());
            }
            return BadRequest();
        }
        [HttpGet("{Id}")]
        public ActionResult<BlTrainer> GetById(int Id)
        {
            if (Id == null)
                return BadRequest();
            return Ok(trainers.Get(Id));
        }

        [HttpPost]
        public ActionResult<BlTrainer> Add([FromBody] BlTrainer bl, [FromQuery] int startHour, int endHour)
        {
            if (bl == null)
                return BadRequest();
            Ok(trainers.Add(bl));
            Ok((bl.Code, startHour, endHour));
            return Ok();
        }

        [HttpPut]
        public ActionResult<BlTrainer> Update(BlTrainer bl)
        {
            if (bl == null)
                return BadRequest();
            return Ok(trainers.Update(bl));
        }

        [HttpDelete]
        public void Delete(int id)
        {
            trainers.Delete(id);
        }

    }
}
