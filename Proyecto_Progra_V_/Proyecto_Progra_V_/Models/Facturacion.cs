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
        public string AdicionadoPor { get; set; }
        public DateTime FechaAdicion { get; set; } = DateTime.Now;
        public string ModificadoPor { get; set; }
        public DateTime? FechaModificacion { get; set; } = DateTime.Now;

  
        public Facturacion() { }

        public Facturacion(int idFacturacion, int idPaciente, int idEmpleado, DateTime fechaFacturacion, decimal montoTotal, string estadoPago, string adicionadoPor, DateTime fechaAdicion, string modificadoPor, DateTime? fechaModificacion)
        {
            IdFacturacion = idFacturacion;
            IdPaciente = idPaciente;
            IdEmpleado = idEmpleado;
            FechaFacturacion = fechaFacturacion;
            MontoTotal = montoTotal;
            EstadoPago = estadoPago;
            AdicionadoPor = adicionadoPor;
            FechaAdicion = fechaAdicion;
            ModificadoPor = modificadoPor;
            FechaModificacion = fechaModificacion;
        }
    }
}