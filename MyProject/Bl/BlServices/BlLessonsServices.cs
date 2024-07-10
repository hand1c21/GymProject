using Bl.BlApi;
using Bl.BlDalModels;
using Bl.BlModels;
using AutoMapper;
using Dal;
using Dal.DalApi;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlServices
{
    internal class BlAppointmentsServices : IBlAppointment
    {
        Dal.DalApi.IAppointments blAppointments;
        IMapper map;
        public BlAppointmentsServices(DalManager instance)
        {
            this.blAppointments = instance.Appointment;
        }


        public List<BlDalAppointment> GetAll()
        {
            List<Appointment> excersizers = blAppointments.GetAll();
            List<BlDalAppointment> excersizers1 = new List<BlDalAppointment>();
            for (int i = 0; i < excersizers.Count; i++)
            {
                excersizers1.Add(map.Map<BlDalAppointment>(excersizers[i]));
            }
            return excersizers1;

        }

        public BlDalAppointment Get(int id)
        {
            Appointment ex = blAppointments.Get(id);
            if (ex != null)
            {
                BlAppointment excersizer = (BlAppointment)map.Map<BlDalAppointment>(ex);
                return excersizer;
            }
            return null;
        }

        public BlDalAppointment Add(BlDalAppointment entity)
        {
            Appointment excersizer = map.Map<Appointment>(entity);
            blAppointments.Add(excersizer);
            return (BlAppointment)entity;
        }

        public void Delete(int id)
        {
            blAppointments.Delete(id);
        }

        public BlDalAppointment Update(BlDalAppointment entity)
        {
            Appointment ex = blAppointments.Get(entity.Id);
            if (ex != null)
            {
                blAppointments.Update(ex);
            }
            else Add(entity);
            return (BlAppointment)entity;
        }

        public string IsTimeSlotAvailable(int excersizerId, int day, int time)
        {
            var appointments = blAppointments.GetAll(); // Assume this method retrieves all appointments

            foreach (var appointment in appointments)
            {
                if (appointment.Day == day && appointment.Hour.Hour == time)
                {
                    appointment.ExcersizerId = excersizerId;
                    blAppointments.Add(appointment);
                    return "your appointment was added";
                }
            }

            return "could not find an appointment for the hour and day that you selected"; // Time slot is available
        }
    }
}
