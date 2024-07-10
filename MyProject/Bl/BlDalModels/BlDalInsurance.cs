using System;
using System.Collections.Generic;

namespace Bl.BlDalModels;

public class BlDalInsurance
{
    public int Code { get; set; }

    public string InsuranceName { get; set; } = null!;

    public int InsuranceDiscountInPercentages { get; set; }

    public int? NumOfLessonsIntitled { get; set; }

    //public virtual ICollection<Excersizer> Excersizers { get; set; } = new List<Excersizer>();
}
