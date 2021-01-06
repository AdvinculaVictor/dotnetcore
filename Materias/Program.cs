using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Materias
{
    class Program
    {
        static void Main(string[] args)
        {
            AppEscuelaContext db = new AppEscuelaContext();
            var materias = db.Materias.AsNoTracking();
            foreach(Materia materia in materias){
                Console.WriteLine($"Nombre de la materia: {materia.materia}, Descripción: {materia.descripcion}");
            }
        }
    }
}
