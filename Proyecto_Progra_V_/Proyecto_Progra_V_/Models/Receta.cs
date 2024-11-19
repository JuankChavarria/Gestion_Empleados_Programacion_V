using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Progra_V_.Models
{
    public class Receta
    {
        public int IdReceta { get; set; }
        public int IdPciente { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime FechaReceta { get; set; }
        public string NombreMedicamento { get; set; }
        public string Dosis { get; set; }


        public Receta() { }

        public Receta(int idReceta, int idPciente, int idEmpleado, DateTime fechaReceta, string nombreMedicamento, string dosis)
        {
            IdReceta = idReceta;
            IdPciente = idPciente;
            IdEmpleado = idEmpleado;
            FechaReceta = fechaReceta;
            NombreMedicamento = nombreMedicamento;
            Dosis = dosis;
        }
    }
}