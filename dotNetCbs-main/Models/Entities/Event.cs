using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;


namespace cbsStudents.Models.Entities;

public class Event
{
    public int EventId { get; set; }

    [Required(ErrorMessage = "Please enter a title of the event")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Please enter a description of the event")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Please select the start date of the event")]
     public DateTime StartDate { get; set; }


    [Required(ErrorMessage = "Please select the end date of the event")]
     public DateTime EndDate { get; set; }

    [Required(ErrorMessage = "Please enter a description of the event")]
    public string Location { get; set; }

    [Required(ErrorMessage = "Please select the status of the event")]
    public EventStatus Status { get; set; }

    public List<Volunteer> Volunteers { get; set; }

    // public string UserId { get; set; }
    // public IdentityUser? User { get; set; }

   



   


}

