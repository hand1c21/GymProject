using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Excersizer
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string MobileNumber { get; set; } = null!;

    public int InsuranceCode { get; set; }

    public int? NumOfLessonsDone { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual Insurance InsuranceCodeNavigation { get; set; } = null!;
}
