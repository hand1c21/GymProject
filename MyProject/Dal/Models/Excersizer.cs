using System;
using System.Collections.Generic;

namespace Dal.Do.Models;

public partial class Excersizer
{
    public string Id { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string MobileNumber { get; set; } = null!;

    public int? AddressId { get; set; }

    public int TrainerCode { get; set; }

    public int InsuranceCode { get; set; }

    public virtual Address? Address { get; set; }

    public virtual Insurance InsuranceCodeNavigation { get; set; } = null!;

    public virtual Trainer TrainerCodeNavigation { get; set; } = null!;
}
