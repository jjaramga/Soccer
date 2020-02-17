using System.ComponentModel.DataAnnotations;

namespace Soccer.web.Data.Entities
{
    public class TeamEntity
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "The field {Name} can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {Name} is mandatory.")]
        public string Name { get; set; }

        public string LogoPath { get; set; }
    }
}
