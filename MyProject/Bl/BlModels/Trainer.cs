using System;
using System.Collections.Generic;

namespace Bl.BlModels;

public partial class Trainer
{
    public int Code { get; set; }

    public string Id { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string MobileNumber { get; set; } = null!;

    public int? AddressId { get; set; }

    public int TypeOfTrainingCode { get; set; }

    public int Salary { get; set; }

    public int HourOfWork { get; set; }

    public virtual Address? Address { get; set; }

    public virtual ICollection<Excersizer> Excersizers { get; set; } = new List<Excersizer>();

    public virtual TypeOfTraining TypeOfTrainingCodeNavigation { get; set; } = null!;
}
