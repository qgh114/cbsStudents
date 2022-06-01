using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace cbsStudents.Models.Entities;

public class Volunteer
{
    public int VolunteerId { get; set; }


    [Required(ErrorMessage = "Please enter the volunteers name")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Please write the volunteers study programme")]
    public string StudyProgramme { get; set; }

    [Required(ErrorMessage = "Please enter the starting day of the volunteer")]
    public DateTime StartDate { get; set; }

    [Required(ErrorMessage = "Please select the group of the volunteer")]
    public VolunteerEnum Group { get; set; }

    public int EventId { get; set; }
    public Event Event { get; set; }

    public string UserId { get; set; }
    public IdentityUser? User { get; set; }


   

   
   
  

   
      


}

