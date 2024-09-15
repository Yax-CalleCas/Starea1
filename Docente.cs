using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea.Semana1
{
    internal class Docente
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int HorasTrabajadas { get; set; }
        public double TarifaHoraria { get; set; }

        // Constructor
        public Docente(int codigo, string nombre, int horasTrabajadas, double tarifaHoraria)
        {
            Codigo = codigo;
            Nombre = nombre;
            HorasTrabajadas = horasTrabajadas;
            TarifaHoraria = tarifaHoraria;
        }
        // Método para calcular el sueldo bruto
        public double CalcularSueldoBruto()
        {
            return HorasTrabajadas * TarifaHoraria;
        }
        // Método para calcular el descuento
        public double CalcularDescuento()
        {
            double sueldoBruto = CalcularSueldoBruto();
            if (sueldoBruto < 4500)
            {
                return sueldoBruto * 0.12;
            }
            else if (sueldoBruto >= 4500 && sueldoBruto < 6500)
            {
                return sueldoBruto * 0.14;
            }
            else
            {
                return sueldoBruto * 0.16;
            }
        }
        // Método para calcular el sueldo neto
        public double CalcularSueldoNeto()
        {
            return CalcularSueldoBruto() - CalcularDescuento();
        }
    }
}