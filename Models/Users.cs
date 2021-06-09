using  System.ComponentModel.DataAnnotations;

namespace CRUD
{
    public class Users
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }   
        public string Password { get; set; }

    }
}