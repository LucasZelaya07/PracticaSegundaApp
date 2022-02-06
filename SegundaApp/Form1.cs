using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundaApp
{
    public partial class FrmSegundaApp : Form
    {
        //Consigna:
        //Al presionar el botón "Aceptar" se debe validar que los text
        //"Apellido, Nombre, Edad y Direccion" tengan datos, en caso de estar vacios
        //marcarlos de color rojo.
        //Si pasa la validación, los datos se deben escribir en el text de "Resultado"
        //(TextBox multilínea) con el siguiente formato:
        //Apellido y Nombre: XXXXXXXX
        //Edad: XXX
        //Dirección: XXXXXXXXXX
        //En el campo "Edad" solo debe aceptar números.
        //En todos los campos limitar la cantidad de caracteres y pasarlos a mayúsculas.
        //Al presionar el botón "Cancelar" se debe cerrar la app.
        public FrmSegundaApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a mi segunda app");
        }

        private void TxtBxEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar <48 || e.KeyChar >59) && e.KeyChar !=8)
                e.Handled = true;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string Apellido = TxtBxApellido.Text;
            if (TxtBxApellido.Text == "")
                TxtBxApellido.BackColor = Color.Red;
            else TxtBxApellido.BackColor = System.Drawing.SystemColors.Control;
            string Direccion = TxtBxDireccion.Text;
            if (TxtBxDireccion.Text == "")
                TxtBxDireccion.BackColor = Color.Red;
            else TxtBxDireccion.BackColor = System.Drawing.SystemColors.Control;
            string Edad = TxtBxEdad.Text;
            if (TxtBxEdad.Text == "")
                TxtBxEdad.BackColor = Color.Red;
            else TxtBxEdad.BackColor = System.Drawing.SystemColors.Control;
            string TextoNombre = TxtBxNombre.Text;
            if (TxtBxNombre.Text == "")
                TxtBxNombre.BackColor = Color.Red;
            else TxtBxNombre.BackColor = System.Drawing.SystemColors.Control;
            RTxtBxResultado.Text = "Apellido y Nombre: " + Apellido + " " + TextoNombre + Environment.NewLine + "Edad: " + Edad + Environment.NewLine + "Dirección: " + Direccion;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmSegundaApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Gracias por utilizar mi app" + Environment.NewLine + "Atte: Lucas Zelaya");
        }
    }
}
