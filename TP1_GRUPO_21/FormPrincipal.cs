using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GRUPO_21
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // A partir del evento click izquierdo del raton
        {
            Form1ej ejercicio1Form = new Form1ej(this); // Creo el formulario del ejercicio 1, y le paso el formulario principal como referencia
            ejercicio1Form.Show(); // Muestro el formulario
            this.Hide(); // Oculto el formulario principal (this)
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button2ej_Click(object sender, EventArgs e)
        {
            Form2ej ejercicio2Form = new Form2ej(this);
            ejercicio2Form.Show();
            this.Hide();
        }
    }
}
