using Bl;
using Bl.BlApi;
using Bl.BlModels;
using Dal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonsController : ControllerBase
    {
        IBlLessons lessons;
        public LessonsController(BLManager bl)
        {
            this.lessons = bl.Lessons;
        }
        //IExcersizers contexr;

        [HttpGet]
        public ActionResult<List<BlLesson>> Get()
        {
            if (lessons.GetAll() != null)
            {
                return Ok(lessons.GetAll());
            }
            return BadRequest();
        }
        [HttpGet("{Id}")]
        public ActionResult<BlLesson> GetById(int Id)
        {
            if (Id == null)
                return BadRequest();
            return Ok(lessons.Get(Id));
        }

        [HttpPost]
        public ActionResult<BlLesson> Add([FromBody] BlLesson bl)
        {
            if (bl == null)
                return BadRequest();
            return Ok(lessons.Add(bl));
        }
        [HttpDelete]
        public void Delete(int id)
        {
            lessons.Delete(id);
        }

    }
}
