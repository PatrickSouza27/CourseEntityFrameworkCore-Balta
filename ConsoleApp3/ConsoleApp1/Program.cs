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
                var infoCurso = context.Cursos.AsNoTracking()
                    .Include(x => x.Categoria)
                    .OrderBy(x => x.IdCurso)
                    .ToList();

                infoCurso.ForEach(x => { Console.WriteLine(x.IdCurso + " - " + x.Name + " - " + x.Categoria?.Name); });


                var infoCurso2 = context.Cursos
                    .Include(x => x.Categoria)
                    .OrderBy(x => x.IdCurso)
                    .Where(x=> x.IdCurso == 12)
                    .FirstOrDefault();

                infoCurso2.Name = "OCI";
                context.Cursos.Update(infoCurso2);
                context.SaveChanges();


            }
        }
    }
}