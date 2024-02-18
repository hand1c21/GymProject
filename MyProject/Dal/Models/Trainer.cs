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

    public int Salary { get; set; }

    public int HourOfWork { get; set; }

    public string? EmailAddress { get; set; }

    public virtual ICollection<Excersizer> Excersizers { get; set; } = new List<Excersizer>();

    public virtual ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();

    public virtual TypeOfTraining TypeOfTrainingCodeNavigation { get; set; } = null!;
}
