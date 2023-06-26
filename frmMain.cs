using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace PryCantallopsIEFI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //evento load donde se carga el combo box de paises
        private void frmMain_Load(object sender, EventArgs e)
        {
            //llamo al objeto conexion para utilizar el evento de cargar los paises en el combo box
            ClsConexion cls = new ClsConexion();
            cls.CargarPaises(cmbPais);
        }

        
        //propiedad para que solo se pueden poner numeros en el textbox edad
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignora el carácter ingresado si no es un número o una tecla de control
            }
        }


        //evento boton de registro para registar un nuevo socio
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            //booleano para determinar el tipo de sexo utilizando el boton de opcion
            bool sexo=true;
            if (optMasculino.Checked == true) 
            {
                sexo = true;
            }
            else
            {
                if (optFemenino.Checked == true)
                {
                    sexo = false;
                }
            }

            //llamo el objeto de la clase conexion para escribir un nuevo socio en la base de datos
            ClsConexion obj = new ClsConexion();
            obj.RegistrarSocio(txtNombre.Text, txtApellido.Text, cmbPais.Text, Convert.ToInt32(txtEdad.Text), sexo, Convert.ToDecimal(txtIngreso.Text), Convert.ToInt32(txtPuntaje.Text));
            LimpiarDatos();
        }



        //eventos para la validacion del ingreso de datos, para evitar errores en la interfaz
        private void optFemenino_CheckedChanged(object sender, EventArgs e)
        {
            if (optFemenino.Checked == true)
            {
                txtIngreso.Text = "1000";
                txtPuntaje.Enabled = true;
            }
        }

        private void optMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (optMasculino.Checked == true)
            {
                txtIngreso.Text = "1000";
                txtPuntaje.Enabled = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtNombre.Text != null)
            {
                txtApellido.Enabled = true;
                btnBorrar.Enabled = true;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text != "" && txtApellido.Text != null)
            {
                cmbPais.Enabled = true;
            }
        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPais.SelectedIndex != -1)
            {
                txtEdad.Enabled = true;
            }
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            if (txtEdad.Text != "" && txtEdad.Text != null)
            {
                optMasculino.Enabled = true;
               
                optFemenino.Enabled = true;
            }
        }

        private void txtPuntaje_TextChanged(object sender, EventArgs e)
        {
            if (txtPuntaje.Text != "" && txtPuntaje.Text != "") 
            {
                btnRegistro.Enabled = true;
            }
        }

        //evento para limpiar la interfaz
        private void LimpiarDatos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtApellido.Enabled = false;
            cmbPais.SelectedIndex = -1;
            cmbPais.Enabled = false;
            txtEdad.Clear();
            txtEdad.Enabled =false;
            optMasculino.Enabled=false;
            optMasculino.Checked = false;
            optFemenino.Checked = false;
            optFemenino.Enabled=false;
            txtIngreso.Enabled=false;
            txtIngreso.Clear();
            txtPuntaje.Enabled=false;
            txtPuntaje.Clear();
            btnRegistro.Enabled=false;
        }

        //boton para limpiar la interfaz
        private void btnBorrar_Click(object sender, EventArgs e)
        {
           LimpiarDatos();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //evento para abrir un nuevo formulario e ingresar un nuevo pais
        private void btnPais_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPais frm = new frmPais();
            frm.ShowDialog();
        }
    }
}
