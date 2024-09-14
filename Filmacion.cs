using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea.Semana1
{
    internal class Filmacion
    {
        public int codigo {  get; set; }
        public string titulo { get; set; }
        public int  duracionMinutos { get; set; }  
        public double precioSoles {  get; set; }

        //  precio en dólares
        public double ObtenerPrecioEnDolares()
        {
            const double tasaCambio = 3.59; 
            return precioSoles / tasaCambio;
        }
    }
}
