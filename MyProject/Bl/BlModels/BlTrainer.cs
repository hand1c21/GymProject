using System;
using System.Collections.Generic;

namespace Bl.BlModels;

public partial class BlTrainer
{
    public int Code { get; set; }

    //public string Id { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string MobileNumber { get; set; } = null!;

    public int TypeOfTrainingCode { get; set; }

    //public int Salary { get; set; }

    //public int HourOfWork { get; set; }

    public string? EmailAddress { get; set; }

    public virtual ICollection<BlExcersizer> Excersizers { get; set; } = new List<BlExcersizer>();

    //public virtual ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();

    //public virtual TypeOfTraining TypeOfTrainingCodeNavigation { get; set; } = null!;
}
