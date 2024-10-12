using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica4_Formulario
{
    public partial class MostrarDatos : Form
    {
        public MostrarDatos()
        {
            InitializeComponent();
        }

        private void MostrarDatos_Load(object sender, EventArgs e)
        {

        }

        public void ImprimirDatos(string nombre, string apellidos, string edad, string telefono, string estatura, string genero)
        {
            lbl_Nombre.Text = nombre; 
            lbl_Apellido.Text = apellidos;
            lbl_Edad.Text = edad;
            lbl_Estatura.Text = estatura;
            lbl_Telefono.Text = telefono;
            lbl_Genero.Text = genero;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
