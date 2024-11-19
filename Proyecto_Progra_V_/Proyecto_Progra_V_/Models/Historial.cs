using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Progra_V_.Models
{
    public class Historial
    {
        public int IdHistorial { get; set; }
        public int IdPaciente { get; set; }
        public DateTime Fecha { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string Observaciones { get; set; }

        public Historial() { }

        public Historial(int idHistorial, int idPaciente, DateTime fecha, string diagnostico, string tratamiento, string observaciones)
        {
            IdHistorial = idHistorial;
            IdPaciente = idPaciente;
            Fecha = fecha;
            Diagnostico = diagnostico;
            Tratamiento = tratamiento;
            Observaciones = observaciones;
        }
    }
    

}