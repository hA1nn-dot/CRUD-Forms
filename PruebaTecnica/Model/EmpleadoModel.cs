using PruebaTecnica.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using PruebaTecnica.Controllers;

namespace PruebaTecnica.Model
{
    //Hacer Conexion
    //Agregar //Eliminar empleado

    class EmpleadoModel
    {
        // MYSQL Data 8.0.20
        private static readonly string conexionString = "Server=localhost;Port=3306;DataBase=Prueba;Uid=root;password=FhaimX";

        public static void showEmpleados(DataGridView tabla) {
            using (MySqlConnection conexion = new MySqlConnection(conexionString)) {
                conexion.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter("SELECT * FROM empleados WHERE habilitado = 1",conexionString);
                DataSet set = new DataSet();
                adaptador.Fill(set, "empleados");
                tabla.DataSource = set.Tables["empleados"];
            }
        }

        public static void nuevoEmpleado(Empleado empleado) {
            insertEmpleado(empleado);
            insertTelefonos(empleado);
        }


        
        //para borrar un solo empleado
        public static void deleteEmpleado(int IdEmpleado)
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {
                //delete empleado
                try { 
                    conexion.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.CommandText = "UPDATE empleados SET habilitado = 0 WHERE idEmpleados = ?idEmpleado";
                    command.Connection = conexion;
                    command.Parameters.Add("?idEmpleado", MySqlDbType.Int32).Value = IdEmpleado;

                    command.ExecuteNonQuery();
                } catch (MySqlException ex){
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }


        //Obtener Id del empleado
        private static string getLastEmployeeID()
        {
            string idEmpleado = "0";
            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.CommandText = "SELECT idEmpleados FROM empleados WHERE habilitado = 1 ORDER BY idEmpleados DESC limit 1;";
                    command.Connection = conexion;
                    idEmpleado = command.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            return idEmpleado;
        }

        public static List<Telefono> getTelefonosByIdEmpleado(int idEmpleado) {
            List<Telefono> telefonos = new List<Telefono>();
            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.CommandText = "SELECT * FROM telefonos WHERE idEmpleados = ?idEmpleado";
                    command.Parameters.AddWithValue("?idEmpleado", idEmpleado);
                    command.Connection = conexion;
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Telefono telefono = new Telefono(reader.GetString(2), reader.GetString(3), reader.GetString(4));
                        telefonos.Add(telefono);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error obtener telefonos");
                }
            }
            return telefonos;
        }

        private static void insertEmpleado(Empleado empleado) {
            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.CommandText = "INSERT INTO empleados (nombre,apellidoP,apellidoM,edad,genero,puesto,estudios,tipoEmpleado,entidad,calle,num,CP) VALUES (?nombre,?apellidoP,?apellidoM,?edad,?genero,?puesto,?estudio,?tipoEmpleado,?entidad,?calle,?num,?CP)";
                    command.Connection = conexion;

                    command.Parameters.Add("?nombre", MySqlDbType.String).Value = empleado.Nombre;
                    command.Parameters.Add("?apellidoP", MySqlDbType.String).Value = empleado.ApellidoPaterno;
                    command.Parameters.Add("?apellidoM", MySqlDbType.String).Value = empleado.ApellidoMaterno;
                    command.Parameters.Add("?edad", MySqlDbType.String).Value = empleado.Edad;
                    command.Parameters.Add("?genero", MySqlDbType.VarChar).Value = empleado.Genero;
                    command.Parameters.Add("?puesto", MySqlDbType.VarChar).Value = empleado.Puesto;
                    command.Parameters.Add("?estudio", MySqlDbType.VarChar).Value = empleado.Estudios;
                    command.Parameters.Add("?tipoEmpleado", MySqlDbType.VarChar).Value = empleado.TipoEmpleado;
                    command.Parameters.Add("?entidad", MySqlDbType.VarChar).Value = empleado.EntidadFederativa;
                    command.Parameters.Add("?calle", MySqlDbType.VarChar).Value = empleado.Calle;
                    command.Parameters.Add("?num", MySqlDbType.VarChar).Value = empleado.Num;
                    command.Parameters.Add("?CP", MySqlDbType.VarChar).Value = empleado.CP;

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Insertar Empleado");
                }
            }
        }

        private static void insertTelefonos(Empleado empleado) {

            string idEmpleado = getLastEmployeeID();
            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {
                MySqlTransaction transaction = null;
                try
                {
                    conexion.Open();
                    transaction = conexion.BeginTransaction();

                    MySqlCommand command = new MySqlCommand();
                    foreach (Telefono telefono in empleado.Telefonos)
                    {
                        
                        command.CommandText = "INSERT INTO telefonos (idEmpleados,extension,telefono,tipo) VALUES (?idEmpleados,?extension,?telefono,?tipo)";
                        command.Connection = conexion;

                        command.Parameters.AddWithValue("?idEmpleados", idEmpleado);
                        command.Parameters.AddWithValue("?extension", telefono.Extension);
                        command.Parameters.AddWithValue("?telefono", telefono.Numero);
                        command.Parameters.AddWithValue("?tipo", telefono.Tipo);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                        command.Dispose();
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message, "Error Rollback");
                }

            }
        }

    }
}
