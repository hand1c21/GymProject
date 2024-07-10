using System;
using System.Collections.Generic;

namespace Bl.BlDalModels;

public class BlDalAppointment
{
    public int Id { get; set; }

    public int TrainerCode { get; set; }

    public int Day { get; set; }


    public DateTime Hour { get; set; }

    public int? ExcersizerId { get; set; }

    //public virtual Excersizer? Excersizer { get; set; }

    //public virtual Trainer TrainerCodeNavigation { get; set; } = null!;
}
