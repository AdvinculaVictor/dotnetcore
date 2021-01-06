using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Alumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppAlumnosContext()){
                var alumnos = db.Alumnos.AsNoTracking();
                foreach(Alumno alumno in alumnos){
                    Console.WriteLine($"Alumno: {alumno.Nombre}, Grado: {alumno.Grado}, Grupo: {alumno.Grupo}");
                }
            }
        }
    }
}