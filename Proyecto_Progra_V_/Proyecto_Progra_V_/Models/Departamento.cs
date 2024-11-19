using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Progra_V_.Models
{
    public class Departamento
    {

        public int IdDepartamento { get; set;}
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Departamento() { }

        public Departamento(int idDepartamento , string nombre, string descripcion)
        {
            IdDepartamento = idDepartamento;
            Nombre = nombre;
            Descripcion = descripcion;
        }



    }
}