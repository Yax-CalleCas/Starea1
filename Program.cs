using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea.Semana1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //EJERCICIO 1
             Filmacion video = new Filmacion(); 
             video.codigo = 1;
             video.titulo = "  El rey león ";
             video.duracionMinutos = 122;
             video.precioSoles = 35.90;

             Console.WriteLine("Datos de la Filmación: ");
             Console.WriteLine($"Código: {video.codigo}");
             Console.WriteLine($"Título: {video.titulo}");
             Console.WriteLine($"Duración en minutos: {video.duracionMinutos}");
             Console.WriteLine($"Precio en soles S/: {video.precioSoles:C}");

             Console.WriteLine($"Precio en dólares: {video.ObtenerPrecioEnDolares():C}");
            

            */
            /*
            // Creación del objeto Persona EJERCICIO 2
            Persona persona = new Persona();

            persona.nombre = "Yaxon";
            persona.apellido = "Castillo";
            persona.edad = 20;
            persona.estatura = 1.70;
            persona.peso = 60;     

            // IMPRIMIR
            Console.WriteLine("Datos de la Persona: ");
            Console.WriteLine($"Nombre: {persona.nombre}");
            Console.WriteLine($"Apellido: {persona.apellido}");
            Console.WriteLine($"Edad: {persona.edad} ({persona.ObtenerEstadoEdad()})");
            Console.WriteLine($"Estatura: {persona.estatura} m");
            Console.WriteLine($"Peso: {persona.peso} kg");

            //  (IMC)
            Console.WriteLine($"Índice de Masa Corporal (IMC): {persona.CalcularIMC():F2}");
            

                 */

            // tarecer EJERCICIO
            Coordinador coordinador = new Coordinador();

            coordinador.codigo = 102;
            coordinador.nombre = "Yaxon Castillo";
            coordinador.categoria = 2; 
            coordinador.numeroCelular = 918751566;

            
            Console.WriteLine("Datos del Coordinador:");
            Console.WriteLine($"Código: {coordinador.codigo}");
            Console.WriteLine($"Nombre: {coordinador.nombre}");
            Console.WriteLine($"Categoría: {coordinador.categoria}");
            Console.WriteLine($"Número de Celular: {coordinador.numeroCelular}");

            // sueldo del coordinador
            Console.WriteLine($"Sueldo: S/ {coordinador.ObtenerSueldo():F2}");
                 
            Console.ReadKey();
        } 
    }
}
