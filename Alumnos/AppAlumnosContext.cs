using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace Alumnos
{
    public class AppAlumnosContext:DbContext
    {
        private const string connectionString = @"Data Source=localhost;Initial Catalog=Ejercicios;User Id=sa;Password=Bewjodvmb*1;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer(connectionString);
        } 
        public DbSet<Alumno> Alumnos{get;set;}
    }
}