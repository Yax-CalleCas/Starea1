using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea.Semana1
{
    internal class Coordinador
    {
        
        public int codigo { get; set; }
        public string nombre { get; set; }
        public int categoria { get; set; }
        public int numeroCelular { get; set; }

        // sueldo del coordinador
        public double ObtenerSueldo()
        {
            switch (categoria)
            {
                case 0:
                    return 8500;
                case 1:
                    return 6850;
                case 2:
                    return 5500;
                default:
                    return 0; // Categoría no válida
            }
        }
    }
}