using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Trainer
{
    public int Code { get; set; }

    public string Id { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string MobileNumber { get; set; } = null!;

    public int TypeOfTrainingCode { get; set; }

    public int SalaryForHour { get; set; }

    public int HourOfWork { get; set; }

    public string? EmailAddress { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual TypeOfTraining TypeOfTrainingCodeNavigation { get; set; } = null!;
}
