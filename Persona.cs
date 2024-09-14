using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea.Semana1
{
    internal class Persona
    {
        // Atributos públicos
        public string nombre;
        public string apellido;
        public int edad;
        public double estatura; // en metros
        public double peso;     // en kilogramos

        public string ObtenerEstadoEdad()
        {
            return edad < 18 ? "menor de edad" : "mayor de edad";
        }
 
        public double CalcularIMC()
        {
            return peso / (estatura * estatura);
        }
    }
}