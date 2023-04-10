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
                var categorias = context.Categorias.Skip(0).Take(4).ToList();
                categorias.ForEach(c => { Console.WriteLine(c.Name); });
                Console.WriteLine("---------------------------------------");
                var categorias2 = context.Categorias.Skip(4).Take(4).ToList();
                categorias2.ForEach(c => { Console.WriteLine(c.Name); });

            }
        }
    }
}