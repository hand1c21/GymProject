using System;
using System.Collections.Generic;

namespace Bl.BlDalModels;

public partial class BlDalTrainer
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

    public virtual ICollection<BlDalExcersizer> Excersizers { get; set; } = new List<BlDalExcersizer>();

    public virtual ICollection<BlDalLesson> Lessons { get; set; } = new List<BlDalLesson>();

    public virtual BlDalTypeOfTraining TypeOfTrainingCodeNavigation { get; set; } = null!;
}
