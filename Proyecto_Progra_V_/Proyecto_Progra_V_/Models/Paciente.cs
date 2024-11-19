using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Progra_V_.Models
{
    public class Paciente
    {
        public int IdPaciente { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Sexo { get; set; }
        public string Direccion { get; set; }

        public Paciente() { }

        public Paciente(int idPaciente, string nombre, string apellido, string correo, string telefono, string sexo, string direccion)
        {
            IdPaciente = idPaciente;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Telefono = telefono;
            Sexo = sexo;
            Direccion = direccion;
        }
    }




}