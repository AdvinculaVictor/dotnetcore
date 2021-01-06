using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppVentaCursosContext()){
                var cursos = db.Curso.AsNoTracking(); //Devuelve IQueryable
                foreach(Curso c in cursos){
                    Console.WriteLine(c.Titulo + " - " + c.Descripcion);
                }
                var cursosPrecios = db.Curso.Include(p=>p.PrecioPromocion);
                foreach(var c in cursosPrecios){
                    Console.WriteLine(c.Titulo + " - " + c.PrecioPromocion.PrecioActual);
                }                
                var cursosComentarios = db.Curso.Include(p=>p.PrecioPromocion).Include(p=>p.ComentarioLista).AsNoTracking();
                foreach(var c in cursosComentarios){
                    Console.WriteLine(c.Titulo + " - " + c.PrecioPromocion.PrecioActual);
                    foreach(var com in c.ComentarioLista){
                        Console.WriteLine("= = = " + com.Alumno + " - " + com.ComentarioTexto);
                    }
                }
                // var Cursos = db.Curso.Include(c=>c.InstructorLink).ThenInclude(ci=>ci.Instructor);
                // foreach(var c in Cursos){
                //     Console.WriteLine(c.Titulo + " - " + c.Descripcion);
                //     foreach(var insLink in c.InstructorLink){
                //         Console.WriteLine(" * * * * * " + insLink.Instructor.Nombre);
                //     }
                // }
            }
        }
    }
}
