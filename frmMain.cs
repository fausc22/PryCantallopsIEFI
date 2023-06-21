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

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
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
            ClsConexion obj = new ClsConexion();
            obj.RegistrarSocio(txtNombre.Text, txtApellido.Text, txtLugar.Text, Convert.ToInt32(txtEdad.Text), sexo, Convert.ToDecimal(txtIngreso.Text), Convert.ToInt32(txtPuntaje.Text));
        }
    }
}
