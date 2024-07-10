using Bl.BlDalModels;
using System;
using System.Collections.Generic;

namespace Bl.BlModels;

public partial class BlAppointment : BlDalAppointment
{
    //public int Id { get; set; }

    public int TrainerCode { get; set; }

    public int Day { get; set; }


    public DateTime Hour { get; set; }

    public int? ExcersizerId { get; set; }

    //public virtual Excersizer Excersizer { get; set; } = null!;

    //public virtual Trainer Trainer { get; set; } = null!;
}
