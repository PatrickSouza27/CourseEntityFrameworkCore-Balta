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
                //var tag = new Categoria { Name = "Oracle Cloud" };
                //context.Categorias.Add(tag);
                //context.SaveChanges();

                //var tag2 = context.Categorias.FirstOrDefault(x => x.Name == "Oracle Cloud");
                //tag2.Name = "Azure 2";
                //context.Update(tag2);
                //context.SaveChanges();

                //var tag3 = context.Categorias.FirstOrDefault(x => x.Id == 17);
                //context.Remove(tag3);
                //context.SaveChanges();

                //var tag3 = context.Categorias.First();
                //Console.WriteLine(tag3.Name);

                //var tag4 = context.Categorias;
                //foreach (var tag in tag4)
                //{
                //    Console.WriteLine(tag.Name);
                //}

                var tag = context.Categorias.Where(x => x.Name == "Azure").AsNoTracking().ToList();
                tag.ForEach(x=> Console.WriteLine(x.Id));
            }
        }
    }
}