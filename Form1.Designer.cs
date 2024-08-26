namespace Practica4_Formulario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lbl_Apellidos = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.lbl_Estatura = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.tb_Apellidos = new System.Windows.Forms.TextBox();
            this.tb_Telefono = new System.Windows.Forms.TextBox();
            this.tb_Edad = new System.Windows.Forms.TextBox();
            this.tb_estatura = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbt_Hombre = new System.Windows.Forms.RadioButton();
            this.rbt_Mujer = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(58, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre :";
            // 
            // lbl_Apellidos
            // 
            this.lbl_Apellidos.AutoSize = true;
            this.lbl_Apellidos.Location = new System.Drawing.Point(53, 62);
            this.lbl_Apellidos.Name = "lbl_Apellidos";
            this.lbl_Apellidos.Size = new System.Drawing.Size(55, 13);
            this.lbl_Apellidos.TabIndex = 1;
            this.lbl_Apellidos.Text = "Apellidos :";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Location = new System.Drawing.Point(53, 103);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(55, 13);
            this.lbl_Telefono.TabIndex = 2;
            this.lbl_Telefono.Text = "Telefono :";
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Location = new System.Drawing.Point(70, 144);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(38, 13);
            this.lbl_Edad.TabIndex = 3;
            this.lbl_Edad.Text = "Edad :";
            // 
            // lbl_Estatura
            // 
            this.lbl_Estatura.AutoSize = true;
            this.lbl_Estatura.Location = new System.Drawing.Point(58, 187);
            this.lbl_Estatura.Name = "lbl_Estatura";
            this.lbl_Estatura.Size = new System.Drawing.Size(52, 13);
            this.lbl_Estatura.TabIndex = 4;
            this.lbl_Estatura.Text = "Estatura :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Location = new System.Drawing.Point(129, 21);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(100, 20);
            this.tb_Nombre.TabIndex = 6;
            // 
            // tb_Apellidos
            // 
            this.tb_Apellidos.Location = new System.Drawing.Point(129, 59);
            this.tb_Apellidos.Name = "tb_Apellidos";
            this.tb_Apellidos.Size = new System.Drawing.Size(100, 20);
            this.tb_Apellidos.TabIndex = 7;
            // 
            // tb_Telefono
            // 
            this.tb_Telefono.Location = new System.Drawing.Point(129, 100);
            this.tb_Telefono.Name = "tb_Telefono";
            this.tb_Telefono.Size = new System.Drawing.Size(100, 20);
            this.tb_Telefono.TabIndex = 8;
            // 
            // tb_Edad
            // 
            this.tb_Edad.Location = new System.Drawing.Point(129, 141);
            this.tb_Edad.Name = "tb_Edad";
            this.tb_Edad.Size = new System.Drawing.Size(100, 20);
            this.tb_Edad.TabIndex = 9;
            // 
            // tb_estatura
            // 
            this.tb_estatura.Location = new System.Drawing.Point(129, 184);
            this.tb_estatura.Name = "tb_estatura";
            this.tb_estatura.Size = new System.Drawing.Size(100, 20);
            this.tb_estatura.TabIndex = 10;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(61, 374);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 11;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(155, 374);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 12;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbt_Mujer);
            this.groupBox1.Controls.Add(this.rbt_Hombre);
            this.groupBox1.Location = new System.Drawing.Point(56, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genero :";
            // 
            // rbt_Hombre
            // 
            this.rbt_Hombre.AutoSize = true;
            this.rbt_Hombre.Location = new System.Drawing.Point(5, 45);
            this.rbt_Hombre.Name = "rbt_Hombre";
            this.rbt_Hombre.Size = new System.Drawing.Size(62, 17);
            this.rbt_Hombre.TabIndex = 14;
            this.rbt_Hombre.TabStop = true;
            this.rbt_Hombre.Text = "Hombre";
            this.rbt_Hombre.UseVisualStyleBackColor = true;
            // 
            // rbt_Mujer
            // 
            this.rbt_Mujer.AutoSize = true;
            this.rbt_Mujer.Location = new System.Drawing.Point(142, 45);
            this.rbt_Mujer.Name = "rbt_Mujer";
            this.rbt_Mujer.Size = new System.Drawing.Size(51, 17);
            this.rbt_Mujer.TabIndex = 15;
            this.rbt_Mujer.TabStop = true;
            this.rbt_Mujer.Text = "Mujer";
            this.rbt_Mujer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.tb_estatura);
            this.Controls.Add(this.tb_Edad);
            this.Controls.Add(this.tb_Telefono);
            this.Controls.Add(this.tb_Apellidos);
            this.Controls.Add(this.tb_Nombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_Estatura);
            this.Controls.Add(this.lbl_Edad);
            this.Controls.Add(this.lbl_Telefono);
            this.Controls.Add(this.lbl_Apellidos);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Formulario de Registro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lbl_Apellidos;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_Edad;
        private System.Windows.Forms.Label lbl_Estatura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.TextBox tb_Apellidos;
        private System.Windows.Forms.TextBox tb_Telefono;
        private System.Windows.Forms.TextBox tb_Edad;
        private System.Windows.Forms.TextBox tb_estatura;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbt_Mujer;
        private System.Windows.Forms.RadioButton rbt_Hombre;
    }
}

