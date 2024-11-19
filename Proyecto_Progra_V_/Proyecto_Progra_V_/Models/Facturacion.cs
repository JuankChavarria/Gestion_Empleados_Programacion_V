using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Progra_V_.Models
{
    public class Facturacion
    {
        public int IdFacturacion { get; set; }
        public int IdPaciente { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime FechaFacturacion  { get; set; } = DateTime.Now;
        public decimal MontoTotal { get; set; }
        public string EstadoPago { get; set; }

        public Facturacion(int idFacturacion, int idPaciente, int idEmpleado, DateTime FechaFacturacion, decimal fechaFacturacion, string estadoPago)
        {
            IdFacturacion = idFacturacion;
            IdPaciente = idPaciente;
            IdEmpleado = idEmpleado;
            FechaFacturacion = FechaFacturacion;
            MontoTotal = fechaFacturacion;
            EstadoPago = estadoPago;
        }
        public Facturacion() { }


    }
}