using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace Materias
{
    public class AppEscuelaContext:DbContext
    {
        private string conexion = "Data source=.;Initial catalog=Ejercicios;User Id=sa;password=Bewjodvmb*1;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer(conexion);
        }
        public DbSet<Materia> Materias{get;set;}
    }
}