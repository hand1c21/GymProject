using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class TrainersWorkingDay
{
    public TrainersWorkingDay(int trainerCode, int day, int start, int end)
    {
        TrainerCode = trainerCode;
        Day = day;
        StartHour = start;
        EndHour = end;
    }

    public int Id { get; set; }

    public int TrainerCode { get; set; }

    public int Day { get; set; }

    public int StartHour { get; set; }

    public int EndHour { get; set; }
}
