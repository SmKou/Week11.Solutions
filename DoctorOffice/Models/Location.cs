using System.ComponentModel.DataAnnotations;

namespace DoctorOffice.Models;

public class Location
{
    public int LocationId { get; set; }
    [Required(ErrorMessage = "Specify room type for location.")]
    public string LocationType { get; set; }
    [Required, Range(0, 100)]
    public int Floor { get; set; }
    [Required, Range(1, 100)]
    public int Room { get; set; }
    
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
}