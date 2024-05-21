using System;
using System.Collections.Generic;

namespace Bl.BlDalModels;

public partial class BlDalLesson
{
    public int Id { get; set; }

    public int TrainerId { get; set; }

    public int ExcersizerId { get; set; }

    public virtual BlDalExcersizer Excersizer { get; set; } = null!;

    public virtual BlDalTrainer Trainer { get; set; } = null!;
}
