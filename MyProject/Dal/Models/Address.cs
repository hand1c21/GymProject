using System;
using System.Collections.Generic;

namespace Dal.Do.Models;

public partial class Address
{
    public int Id { get; set; }

    public string City { get; set; } = null!;

    public string Street { get; set; } = null!;

    public int BuildingNumber { get; set; }

    public int ZipCode { get; set; }

    public virtual ICollection<Excersizer> Excersizers { get; set; } = new List<Excersizer>();

    public virtual ICollection<Trainer> Trainers { get; set; } = new List<Trainer>();
}
