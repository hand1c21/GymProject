using System;
using System.Collections.Generic;

namespace Bl.BlModels;

public partial class BlExcersizer
{
    //private int insuranceCode;
    private ICollection<Dal.Models.Lesson> lessons;

    //public BlExcersizer(string id, string firstName, string lastName, string mobileNumber, int trainerCode, int insuranceCode)
    //{
    //    Id = id;
    //    FirstName = firstName;
    //    LastName = lastName;
    //    MobileNumber = mobileNumber;
    //    TrainerCode = trainerCode;
    //    InsuranceCode = insuranceCode;
    //}

    public BlExcersizer(int id, string firstName, string lastName, string mobileNumber, int trainerCode, int insuranceCode, ICollection<Dal.Models.Lesson> lessons)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        MobileNumber = mobileNumber;
        TrainerCode = trainerCode;
        this.InsuranceCode = insuranceCode;
        this.lessons = lessons;
    }

    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string MobileNumber { get; set; } = null!;

    public int TrainerCode { get; set; }

    public int InsuranceCode { get; set; }

    //public virtual Insurance InsuranceCodeNavigation { get; set; } = null!;

    //public virtual ICollection<BlLesson> Lessons { get; set; } = new List<BlLesson>();

    //public virtual Trainer TrainerCodeNavigation { get; set; } = null!;
}
