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
    public class AppointmentController : ControllerBase
    {
        IBlAppointment appointment;
        public AppointmentController(BLManager bl)
        {
            this.appointment = bl.Appointments;
        }
        //IExcersizers contexr;

        [HttpGet]
        public ActionResult<List<BlAppointment>> Get()
        {
            if (appointment.GetAll() != null)
            {
                return Ok(appointment.GetAll());
            }
            return BadRequest();
        }
        [HttpGet("{Id}")]
        public ActionResult<BlAppointment> GetById(int Id)
        {
            if (Id == null)
                return BadRequest();
            return Ok(appointment.Get(Id));
        }

        [HttpPost]
        public string AddAppointment([FromQuery]int excersizerId, int day, int time)
        {
            return appointment.IsTimeSlotAvailable(excersizerId, day, time);
        }

        [HttpPost]
        public ActionResult<BlAppointment> Add([FromBody] BlAppointment bl)
        {
            if (bl == null)
                return BadRequest();
            return Ok(appointment.Add(bl));
        }

        [HttpPut]
        public ActionResult<BlAppointment> Update(BlAppointment bl)
        {
            if (bl == null)
                return BadRequest();
            return Ok(appointment.Update(bl));
        }
        [HttpDelete]
        public void Delete(int id)
        {
            appointment.Delete(id);
        }

    }
}
