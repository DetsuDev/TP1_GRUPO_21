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
    public partial class Form1ej : Form
    {
        FormPrincipal mainForm;

        public Form1ej(FormPrincipal mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            // Prueba de branch
        }

        private void Form1ej_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text != "")
            {
                lbIzquierda.Items.Add(txtNombres.Text);
                txtNombres.Text = "";
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre");
            }
        }
    }
}
