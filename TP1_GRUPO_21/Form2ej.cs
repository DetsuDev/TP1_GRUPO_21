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
                string nuevoNombre = txtNombre.Text.Trim() + " " + txtApellido.Text.Trim();
                bool yaExiste = false;

                foreach (var item in listElementos.Items)
                {
                   
                    if (item.ToString().ToUpper() == nuevoNombre.ToUpper())
                    {
                        yaExiste = true;
                        break;
                    }
                }

                if (yaExiste)
                {
                    MessageBox.Show("Ese nombre y apellido ya existen en la lista");
                }
                else
                {
                    listElementos.Items.Add(nuevoNombre);
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtNombre.Focus();
                }
            }
            else
            {
                MessageBox.Show("Complete los campos para agregar los elementos a la lista");
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (listElementos.SelectedIndex != -1)
            {
                listElementos.Items.RemoveAt(listElementos.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento de la lista para poder eliminarlo.");
            }
        }
    }
}
