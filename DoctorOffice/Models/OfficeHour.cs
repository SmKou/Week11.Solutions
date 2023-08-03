using System.ComponentModel.DataAnnotations;

namespace DoctorOffice.Models;

public class OfficeHour
{
    public int OfficeHourId { get; set; }
    [Required(ErrorMessage = "Choose a valid weekday.")]
    public string Weekday { get; set; }
    [Required, Range(0, 23)]
    public int OpenHour { get; set; }
    [Required, Range(0, 23)]
    public int ClosedHour { get; set; }
}