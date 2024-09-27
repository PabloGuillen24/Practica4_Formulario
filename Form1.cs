using System;
using System.IO;
using System.Security.AccessControl;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Practica4_Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tb_Edad.TextChanged += validarEdad;
            tb_Nombre.TextChanged += validarNombre;
            tb_Apellidos.TextChanged += validarApellidos;
            tb_estatura.TextChanged += validarEstatura;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
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

            string datos = $"Nombres: {nombres}\r\nApellidos: {apellidos}\r\nEdad: {edad}\r\nEstatura: {estatura}\r\nTelefono: {telefono}\r\nGenero: {genero}\r\n";

            string rutaArchivo = "C:\\Users\\Pablo_GG\\Documents\\UNACH\\Semestre 3\\Programacion Avanzada\\datos.txt";

            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                writer.WriteLine(datos);
            }

            MessageBox.Show("Datos guardados con éxito");
        
        }

        private bool EsEnteroValido(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
        }

        private bool EsDecimalValido(string valor) 
        { 
            decimal resultado;
            return decimal.TryParse(valor,out resultado);
        }

        private bool EsEnteroValido10Digitos(string valor)
        {
            long resultado;
            return long.TryParse(valor, out resultado) && valor.Length==10;
        }

        private bool EsTextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$");
        }

        private void validarEdad(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsEnteroValido(textBox.Text))
            {
                MessageBox.Show("Ingrese una edad valida", "Error edad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void validarEstatura(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsDecimalValido(textBox.Text))
            {
                MessageBox.Show("Ingrese una estatura valida", "Error estatura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void validarNombre(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Ingrese un nombre valido (solo letras y espacios).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void validarApellidos(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Ingrese apellidos validos (solo letras y espacios).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            tb_Nombre.Clear();
            tb_Apellidos.Clear();
            tb_Edad.Clear();
            tb_Telefono.Clear();
            tb_estatura.Clear();
            rbt_Hombre.Checked = false;
            rbt_Mujer.Checked = false;
        }
    }
}

