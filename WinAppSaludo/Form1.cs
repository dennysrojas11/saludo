using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppSaludo
{
    public partial class Form1 : Form
    {
        private TextBox[] textboxs;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxNombre.Focus();
        }

        private void buttonSaludar_Click(object sender, EventArgs e)
        {
            textboxs = new TextBox[] { textBoxNombre, textBoxApellido, textBoxEdad };
            bool datosCorrectos = !textboxs.Any(X => String.IsNullOrEmpty(X.Text));
            

            if (datosCorrectos)
            {
                
                MessageBox.Show("Hola " + textBoxNombre.Text + " " + textBoxApellido.Text+ " ", "Saludo", MessageBoxButtons.OK);   
            }
            else
            {
                MessageBox.Show("Complete todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBoxApellido.Focus();
            }
            Validar.validarletras(e);
        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBoxEdad.Focus();
            }
            Validar.validarletras(e);
        }

        private void textBoxEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buttonSaludar.Focus();
            }
            Validar.validaredad(e);
        }
    }
}
