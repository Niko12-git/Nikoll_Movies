using System.Collections.Generic;
using Nikoll_Movies.DAL.Models;
using Microsoft.EntityFrameworkCore;   

namespace Nikoll_Movies.DAL
{
    public class ApplicationDbContext : DbContext
    {
        //constructor: para poder inicializar la clase base DbContext en otras palabras, virtualizar mi BD
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //Definir los DbSets (tablas) que voy a utilizar en mi aplicaciòn
        public DbSet<Category> Categories { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
