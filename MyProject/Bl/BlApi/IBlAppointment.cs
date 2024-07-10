using Bl.BlDalModels;
using Bl.BlModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlApi
{
    public interface IBlAppointment : IBlCrud<BlDalAppointment>
    {
        string IsTimeSlotAvailable(int excersizerId, int date, int time);
    }
}
