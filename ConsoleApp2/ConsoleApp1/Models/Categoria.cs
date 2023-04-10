using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    [Table("Categoria")]
    public class Categoria
    {      
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(3)]
        [Column("Name", TypeName = "NVARCHAR")]
        public string Name { get; set; }
    }
}
