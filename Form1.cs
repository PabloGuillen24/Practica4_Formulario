using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Practica4_Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            MostrarDatos mostrarDatos = new MostrarDatos();

            String nombres = tb_Nombre.Text;
            String apellidos = tb_Apellidos.Text;
            string edad = tb_Edad.Text;
            string estatura = tb_estatura.Text;
            string telefono = tb_Telefono.Text;
            String genero = "";

            if (rbt_Hombre.Checked)
            {
                genero = rbt_Hombre.Text;
            }
            else if (rbt_Mujer.Checked)
            {
                genero = rbt_Mujer.Text;
            }

            mostrarDatos.ImprimirDatos(nombres, apellidos, edad, telefono, estatura, genero);

            mostrarDatos.Show();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            tb_Nombre.Clear();
            tb_Apellidos.Clear();
            tb_Edad.Clear();
            tb_Telefono.Clear();
            tb_estatura.Clear();
            rbt_Hombre.Checked = false;
            rbt_Mujer .Checked = false;
        }
    }
    }

