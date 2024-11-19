using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Progra_V_.Models
{
    public class Cita
    {
        public int IdCita { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Cita() { }

        public Cita(int idCita, string nombre, string descripcion)
        {
            IdCita = idCita;
            Nombre = nombre;
            Descripcion = descripcion;
        }

    }
}