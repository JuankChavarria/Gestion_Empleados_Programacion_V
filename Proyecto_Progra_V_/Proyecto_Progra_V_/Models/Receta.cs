﻿using System;
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
        public string AdicionadoPor { get; set; }
        public DateTime FechaAdicion { get; set; } = DateTime.Now;
        public string ModificadoPor { get; set; }
        public DateTime? FechaModificacion { get; set; } = DateTime.Now;



        public Receta() { }

        public Receta(int idReceta, int idPciente, int idEmpleado, DateTime fechaReceta, string nombreMedicamento, string dosis, string adicionadoPor, DateTime fechaAdicion, string modificadoPor, DateTime? fechaModificacion)
        {
            IdReceta = idReceta;
            IdPciente = idPciente;
            IdEmpleado = idEmpleado;
            FechaReceta = fechaReceta;
            NombreMedicamento = nombreMedicamento;
            Dosis = dosis;
            AdicionadoPor = adicionadoPor;
            FechaAdicion = fechaAdicion;
            ModificadoPor = modificadoPor;
            FechaModificacion = fechaModificacion;
        }
    }
}