using System;
using System.Collections.Generic;

namespace Bl.BlDalModels;

public partial class BlDalExcersizer
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string MobileNumber { get; set; } = null!;

    public int TrainerCode { get; set; }

    public int InsuranceCode { get; set; }

//    public virtual BlDalInsurance InsuranceCodeNavigation { get; set; } = null!;

//    public virtual ICollection<BlDalLesson> Lessons { get; set; } = new List<BlDalLesson>();

//    public virtual BlDalTrainer TrainerCodeNavigation { get; set; } = null!;
}
