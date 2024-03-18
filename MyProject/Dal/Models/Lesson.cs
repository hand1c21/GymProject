﻿using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Lesson
{
    public int Id { get; set; }

    public int TrainerId { get; set; }

    public int ExcersizerId { get; set; }

    public virtual Excersizer Excersizer { get; set; } = null!;

    public virtual Trainer Trainer { get; set; } = null!;
}
