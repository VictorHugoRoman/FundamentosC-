using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestControles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            decimal edad = nudEdad.Value;
            if (edad <= 0)
            {
                epDato.SetError(nudEdad, "La edad no puede ser menor o igual a 0");                
                return;
            }
            else if (edad >= 18)
                lblMensaje.Text = "Es mayor de edad";
            else
                lblMensaje.Text = "Es menor de edad";
        }
    }
}
