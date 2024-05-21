using Bl.BlDalModels;
using System;
using System.Collections.Generic;

namespace Bl.BlModels;

public partial class BlExcersizer : BlDalExcersizer
{
    private ICollection<Dal.Models.Lesson> lessons;
    public BlExcersizer()
    {
        
    }

    public BlExcersizer(int id, string firstName, string lastName, string mobileNumber, int trainerCode, int insuranceCode, ICollection<Dal.Models.Lesson> lessons)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.MobileNumber = mobileNumber;
        this.TrainerCode = trainerCode;
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
