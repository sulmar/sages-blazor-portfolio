using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models;

public class MessageModel
{
    [Required(ErrorMessage = "Please enter a value for Name.")]
    [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters.")]
    public string Name { get; set; }
    [EmailAddress(ErrorMessage = "Invalid email address.")]
    public string Email { get; set; }
    [Required]
    public string Subject { get; set; }
    public string Content { get; set; }
}
