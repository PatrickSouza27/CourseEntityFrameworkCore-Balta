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
        static async Task Main(string[] args)
        {
            using (var context = new DataContext())
            {
                var NomesCategoria = TodasCategorias(context);
                await foreach (var estupendo in NomesCategoria)
                {
                    Console.WriteLine(estupendo.Name);
                }

            }
        }
        public static async IAsyncEnumerable<Categoria> TodasCategorias(DataContext data)
        {
            await foreach (var categoria in data.Categorias.AsAsyncEnumerable())
            {
                yield return categoria;
            }
        }
    }
}