﻿using System;
using System.Collections.Generic;

namespace Bl.BlModels;

public partial class TypeOfTraining
{
    public int Code { get; set; }

    public string TrainingName { get; set; } = null!;

    public int Price { get; set; }

    public virtual ICollection<Trainer> Trainers { get; set; } = new List<Trainer>();
}
