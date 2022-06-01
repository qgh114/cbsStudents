namespace cbsStudents.Models.Entities;
using System.ComponentModel.DataAnnotations;

public enum VolunteerEnum
{
    [Display(Name = "Volunteer")]
    VOLUNTEER, 

    [Display(Name = "Admin")]
    ADMIN, 

    [Display(Name = "Owner")]
    Owner
}

