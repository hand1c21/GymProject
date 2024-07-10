using System;
using System.Collections.Generic;

namespace Bl.BlDalModels;

public class BlDalExcersizer
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string MobileNumber { get; set; } = null!;

    public int InsuranceCode { get; set; }

    public int? NumOfLessonsDone { get; set; }

    //public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    //public virtual Insurance InsuranceCodeNavigation { get; set; } = null!;
}
