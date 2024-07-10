using System;
using System.Collections.Generic;

namespace Bl.BlDalModels;

public class BlDalTrainersWorkingDay
{
    public int Id { get; set; }

    public int TrainerCode { get; set; }

    public int Day { get; set; }

    public int StartHour { get; set; }

    public int EndHour { get; set; }
}
