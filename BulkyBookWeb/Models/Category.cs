using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models;

public class Category
{
    [Key] // Make sure that Id is a primary key and a identity key
    public int Id { get; set; }
    [Required] // Turn this as a required property
    public string Name { get; set; }
    [Display(Name ="Display Order")]
    [Range(1,100,ErrorMessage ="Display Order must be between 1 and 100.")]
    public int DisplayOrder { get; set; }
    public DateTime CreatedDateTime { get; set; } = DateTime.Now; // Set the default value
}

