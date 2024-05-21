using System;
using System.Collections.Generic;

namespace Bl.BlDalModels;

public partial class BlDalInsurance
{
    public int Code { get; set; }

    public string InsuranceName { get; set; } = null!;

    public int InsuranceDiscountInPercentages { get; set; }

    public virtual ICollection<BlDalExcersizer> Excersizers { get; set; } = new List<BlDalExcersizer>();
}
