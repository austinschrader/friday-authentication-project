using System.ComponentModel.DataAnnotations;

namespace Shop.ViewModels
{
  public class RegisterViewModel
  {
    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    public string Email { get; set; }


  }
}