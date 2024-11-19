using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Proyecto_Progra_V_.Models;

namespace Proyecto_Progra_V.DAL
{
    public class EmpleadoDAL
    {
        private string connectionString;

        public EmpleadoDAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["BD_HospitalSM"].ConnectionString;
        }

        public void CrearEmpleado(Empleado empleado)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_CrearEmpleado", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@Identificacion", empleado.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", empleado.Apellido);
                    cmd.Parameters.AddWithValue("@CorreoElectronico", empleado.Correo);
                    cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                    cmd.Parameters.AddWithValue("@Sexo", empleado.Sexo);
                    cmd.Parameters.AddWithValue("@Departamento", empleado.DepartamentoId);
                    cmd.Parameters.AddWithValue("@Cargo", empleado.Cargo);
                    cmd.Parameters.AddWithValue("@Direccion", empleado.Direccion);
                    cmd.Parameters.AddWithValue("@CantidadVacaciones", empleado.CantidadVacaciones);
                    cmd.Parameters.AddWithValue("@FechaContratacion", empleado.FechaContratacion);
                    cmd.Parameters.AddWithValue("@AdicionadoPor", empleado.AdicionadoPor);
                    cmd.Parameters.AddWithValue("@FechaAdicion", empleado.FechaAdicion);
                    cmd.Parameters.AddWithValue("@FechaAdicion", empleado.FechaAdicion);
                    cmd.Parameters.AddWithValue("@ModificadoPor", empleado.ModificadoPor);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear empleado: " + ex.Message);
            }
        }

        public List<Empleado> LeerEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_LeerEmpleados", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Empleado empleado = new Empleado
                        {
                            IdEmpleado = (int)reader["EmpleadoID"],
                            Nombre = (string)reader["Nombre"],
                            Apellido = (string)reader["Apellidos"],
                            Correo = (string)reader["CorreoElectronico"],
                            Telefono = (string)reader["Telefono"],
                            Sexo = (string)reader["Sexo"],
                            DepartamentoId = (int)reader["Departamento"],
                            Cargo = (string)reader["Cargo"],
                            Direccion = (string)reader["Direccion"],
                            CantidadVacaciones = (int)reader["CantidadVacaciones"],
                            FechaContratacion = (DateTime)reader["FechaContratacion"],
                            AdicionadoPor = (string)reader["AdicionadoPor"],
                            FechaAdicion = (DateTime)reader["FechaAdicion"],
                            ModificadoPor = reader["ModificadoPor"] as string,
                            FechaModificacion = reader["FechaModificacion"] as DateTime?
                        };
                        empleados.Add(empleado);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer empleados: " + ex.Message);
            }
            return empleados;
        }

        public void ActualizarEmpleado(Empleado empleado)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ActualizarEmpleado", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@EmpleadoID", empleado.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", empleado.Apellido);
                    cmd.Parameters.AddWithValue("@CorreoElectronico", empleado.Correo);
                    cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                    cmd.Parameters.AddWithValue("@Sexo", empleado.Sexo);
                    cmd.Parameters.AddWithValue("@Departamento", empleado.DepartamentoId);
                    cmd.Parameters.AddWithValue("@Cargo", empleado.Cargo);
                    cmd.Parameters.AddWithValue("@Direccion", empleado.Direccion);
                    cmd.Parameters.AddWithValue("@CantidadVacaciones", empleado.CantidadVacaciones);
                    cmd.Parameters.AddWithValue("@FechaContratacion", empleado.FechaContratacion);
                    cmd.Parameters.AddWithValue("@ModificadoPor", empleado.ModificadoPor);
                    cmd.Parameters.AddWithValue("@FechaAdicion", empleado.FechaAdicion);
                    cmd.Parameters.AddWithValue("@ModificadoPor", empleado.ModificadoPor);


                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar empleado: " + ex.Message);
            }
        }

        public void EliminarEmpleado(int empleadoID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_EliminarEmpleado", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@EmpleadoID", empleadoID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar empleado: " + ex.Message);
            }
        }
    }
}
