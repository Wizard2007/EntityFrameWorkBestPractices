using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDataAccessLibrary.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(256)]
        public string StreetAdress { get; set; }

        [Required]
        [MaxLength(128)]
        public string City { get; set; }

        [Required]
        [MaxLength(64)]
        public string State { get; set; }

        [Required]
        [MaxLength(16)]
        [Column(TypeName="varchar(16)")]
        public string ZipCode { get; set; }
    }
}
