using Bl;
using Bl.BlApi;
using Bl.BlModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonsController : ControllerBase
    {
        ILessons lessons;
        public LessonsController(BLManager bl)
        {
            this.lessons = bl.Lessons;
        }
        //IExcersizers contexr;

        [HttpGet]
        public ActionResult<List<Lesson>> Get()
        {
            if (lessons.GetAll() != null)
            {
                return Ok(lessons.GetAll());
            }
            return BadRequest();
        }
    }
}
