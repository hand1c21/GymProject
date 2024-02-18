using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Insurance
{
    public int Code { get; set; }

    public string InsuranceName { get; set; } = null!;

    public int InsuranceDiscountInPercentages { get; set; }

    public virtual ICollection<Excersizer> Excersizers { get; set; } = new List<Excersizer>();
}
