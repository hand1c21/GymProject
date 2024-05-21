using System;
using System.Collections.Generic;

namespace Bl.BlDalModels;

public partial class BlDalTypeOfTraining
{
    public int Code { get; set; }

    public string TrainingName { get; set; } = null!;

    public int Price { get; set; }

    public virtual ICollection<BlDalTrainer> Trainers { get; set; } = new List<BlDalTrainer>();
}
