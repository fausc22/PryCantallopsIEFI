using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryCantallopsIEFI
{
    public partial class frmPais : Form
    {
        public frmPais()
        {
            InitializeComponent();
        }

        private void frmPais_Load(object sender, EventArgs e)
        {

        }

        //evento para cerrar el formulario
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frm = new frmMain();
            frm.Show();
        }

        //evento para registrar un nuevo pais en la base de datos
        private void btnRegistro_Click(object sender, EventArgs e)
        {

            //llamo al objeto de la clase conexion para registrar un nuevo pais en la base de datos
            ClsConexion cls = new ClsConexion();
            cls.RegistrarPais(Convert.ToInt32(txtCod.Text), txtPais.Text);

            txtCod.Clear();
            txtPais.Clear();
            
        }


        //evento para que solo puedan ingresarse numeros en el textbox codigo
        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignora el carácter ingresado si no es un número o una tecla de control
            }
        }

        //evento para que el textbox pais siempre comience con mayuscula
        private void txtPais_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string texto = textBox.Text;

            if (!string.IsNullOrEmpty(texto))
            {
                // Convertir la primera letra a mayúscula y el resto a minúsculas
                texto = texto.Substring(0, 1).ToUpper() + texto.Substring(1).ToLower();

                // Actualizar el texto en el TextBox
                textBox.Text = texto;

                // Colocar el cursor al final del texto
                textBox.SelectionStart = texto.Length;
            }

            if (txtPais.Text != "" && txtPais.Text != null)
            {
                btnRegistro.Enabled = true;
            }
        }
    }
}
