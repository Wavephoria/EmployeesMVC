using System.ComponentModel.DataAnnotations;

namespace EmployeesMVC.Models;

public class Employee
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }
    [Required(ErrorMessage = "E-mail is required")]
    [Display(Name = "E-mail")]
    [EmailAddress(ErrorMessage = "Invalid E-mail format")]
    public string Email { get; set; }
}