using Dal.DalApi;
using Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Services
{
    internal class AppointmentServices : IAppointments
    {
        GymContext Context { get; set; }
        public AppointmentServices(GymContext gymContext)
        {
            Context = gymContext;
        }
        public List<Appointment> GetAll()
        {
            List<Appointment> result = Context.Appointments.ToList();
            return result;
        }
        public Appointment Get(int id)
        {
            Appointment Appointment = Context.Appointments.FirstOrDefault(e => e.Id.Equals(id));
            return Appointment;
        }

        public Appointment Add(Appointment entity)
        {
            if (Context.Appointments.Find(entity.Id) == null)
            {
                Context.Appointments.Add(entity);
                Context.SaveChanges();
                return entity;
            }
            return null;
        }


        public void Delete(int id)
        {
            Appointment Appointment = Get(id);
            if (Appointment != null)
            {
                Context.Appointments.Remove(Appointment);
                Context.SaveChanges();
                Console.WriteLine("succses delete");
            }
            else Console.WriteLine("couldn't find");
            //return excersizer;
        }



        public Appointment Update(Appointment entity)
        {
            throw new NotImplementedException();
        }

        public bool IsTimeSlotAvailable(int trainerId, int day, int time)
        {
            // Get appointments for the specific trainer on the given date
            var appointments = Context.Appointments
                .Where(l => l.TrainerCode == trainerId && l.Day == day)
                .ToList();

            // Check if the specified time slot is available
            foreach (var appointment in appointments)
            {
                if (appointment.Hour.Hour == time)
                {
                    return false; // Time slot is not available
                }
            }

            return true; // Time slot is available
        } 

        public void GenerateAppointments()
        {
            var trainers = Context.TrainersWorkingDays.ToList();

            foreach (var trainer in trainers)
            {
                for (int i = trainer.StartHour; i <= trainer.EndHour; i++)
                {
                    Context.Appointments.Add(new Appointment { TrainerCode = trainer.TrainerCode, Day = trainer.Day, Hour = new DateTime(i) });
                }
            }
            Context.SaveChanges();
        }
    }
}