using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDataAccessLibrary.Models
{
    public class Email
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName = "varchar(256)")]
        public string EmailAdress { get; set; }
    }
}
