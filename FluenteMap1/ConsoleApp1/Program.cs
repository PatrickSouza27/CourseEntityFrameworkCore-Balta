using ConsoleApp1.Data;
using ConsoleApp1.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Reflection.Metadata;
using System.Threading.Channels;

namespace EF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DataContext())
            {
                var Cat = new Categoria { Name = "Teste3 " };
                var Cursin = new Curso { Name = "Teste3", Categoria = Cat };

                context.Cursos.Add(Cursin);
                context.SaveChanges();
            }
        }
    }
}