using System;
using System.Collections.Generic;

namespace Bl.BlModels;

public partial class Excersizer
{
    private int insuranceCode;
    //private ICollection<Dal.Models.Lesson> lessons;

    public Excersizer(string id, string firstName, string lastName, string mobileNumber, int trainerCode, int insuranceCode /*,ICollection<Dal.Models.Lesson> lessons*/)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        MobileNumber = mobileNumber;
        TrainerCode = trainerCode;
        this.insuranceCode = insuranceCode;
        //this.lessons = lessons;
    }

    public string Id { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string MobileNumber { get; set; } = null!;

    public int TrainerCode { get; set; }

    //public int InsuranceCode { get; set; }

    //public virtual Insurance InsuranceCodeNavigation { get; set; } = null!;

    public virtual ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();

    //public virtual Trainer TrainerCodeNavigation { get; set; } = null!;
}
