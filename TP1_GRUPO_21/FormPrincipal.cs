using System;
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

        private void button3ej_Click(object sender, EventArgs e)
        {
            Form3ej ejercicio3Form = new Form3ej(this);
            ejercicio3Form.Show();
            this.Hide();
        }
    }
}
