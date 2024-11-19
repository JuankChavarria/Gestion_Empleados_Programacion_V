using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Progra_V_.Models
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Sexo { get; set; }
        public int DepartamentoId { get; set; }
        public string Cargo { get; set; }
        public string Direccion { get; set; }
        public int CantidadVacaciones { get; set; }
        public DateTime FechaContratacion { get; set; }
        public string AdicionadoPor { get; set; }
        public DateTime FechaAdicion { get; set; } = DateTime.Now;
        public string ModificadoPor { get; set; }
        public DateTime? FechaModificacion { get; set; } = DateTime.Now;
    }
}