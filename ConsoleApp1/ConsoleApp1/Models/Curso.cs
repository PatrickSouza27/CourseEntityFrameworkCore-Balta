using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace ConsoleApp1.Models
{
    [Table("Curso")]
    public class Curso
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public int FK_Categoria { get; set; }
    }
}
