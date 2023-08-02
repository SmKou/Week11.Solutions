using System.ComponentModel.DataAnnotations;

namespace DoctorOffice.Models;

public class Location
{
    public int LocationId { get; set; }
    [Required(ErrorMessage = "Location refers to room number."), Range(1, 100000, ErrorMessage = "Enter a valid room number.")]
    public int RoomNo { get; set; }
    public string RoomType { get; set; }

    [Required]
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
}