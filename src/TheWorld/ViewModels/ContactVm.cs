using System.ComponentModel.DataAnnotations;

namespace TheWorld.ViewModels
{
    public class ContactVm
    {
        [Required]
        [StringLength(255, MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(1024, MinimumLength = 5)]
        public string Message { get; set; }
    }
}
