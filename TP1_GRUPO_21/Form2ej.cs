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
    public partial class Form2ej : Form
    {

        FormPrincipal mainForm;
        public Form2ej(FormPrincipal mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }


        private void Form2ej_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
        private void Form2ej_Load(object sender, EventArgs e)
        {
            listElementos.Sorted = true; 
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(txtNombre.Text)) && !(string.IsNullOrWhiteSpace(txtApellido.Text)))
            {
                listElementos.Items.Add(txtNombre.Text + " " + txtApellido.Text);
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("Complete los campos para agregar los elementos a la lista");
            }
        }


    }
}
