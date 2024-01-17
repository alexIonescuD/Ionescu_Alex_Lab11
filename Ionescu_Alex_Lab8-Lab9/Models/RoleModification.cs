using System.ComponentModel.DataAnnotations;

namespace Ionescu_Alex_Lab2.Models
{
    public class RoleModification
    {
        [Required]
        public string RoleName { get; set; }
        public string RoleId { get; set; }
        public string[]? AddIds { get; set; }      //  fara ? returneaza eroare in update
        public string[]? DeleteIds { get; set; }  //  fara ? returneaza eroare in update
        
    }
}
