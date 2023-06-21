using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;


namespace PryCantallopsIEFI
{
    class ClsConexion
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        


        public void RegistrarSocio(string nombre, string apellido, string lugarNacimiento, int edad, bool sexo, decimal ingreso, int puntaje)
        {
            string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EL_CLUB.accdb;Persist Security Info=False;";
            string valorAccess = sexo ? "Yes" : "No";
            //string sql = "INSERT INTO SOCIOS (NOMBRE, APELLIDO, LUGAR_NACIMIENTO, EDAD, SEXO, INGRESO, PUNTAJE) VALUES ('" + nombre + "' , '" + apellido + "' , '" + lugarNacimiento + "' , '" + edad + "' , '" + sexo + "' , '" + ingreso + "' , '" + puntaje + "')";
            string consultaSql = "INSERT INTO SOCIOS (NOMBRE, APELLIDO, LUGAR_NACIMIENTO, EDAD, SEXO, INGRESO, PUNTAJE) " +
                     "VALUES (@nombre, @apellido, @lugarNacimiento, @edad, @sexo, @ingreso, @puntaje)";
            try
            {
                conn = new OleDbConnection(conexion);
                cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.Connection.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consultaSql;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@lugarNacimiento", lugarNacimiento);
                cmd.Parameters.AddWithValue("@edad", edad);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@ingreso", ingreso);
                cmd.Parameters.AddWithValue("@puntaje", puntaje);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "", MessageBoxButtons.OK);

            }
        }
    }
}
