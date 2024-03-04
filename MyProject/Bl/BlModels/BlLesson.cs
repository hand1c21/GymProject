using System;
using System.Collections.Generic;

namespace Bl.BlModels;

public partial class BlLesson
{
    //public int Id { get; set; }

    public int TrainerId { get; set; }

    public string ExcersizerId { get; set; } = null!;

    //public virtual Excersizer Excersizer { get; set; } = null!;

    //public virtual Trainer Trainer { get; set; } = null!;
}
