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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nuevoNombre = txtNombres.Text.Trim();

            if (nuevoNombre == "")
            {
                MessageBox.Show("Debe ingresar un nombre.");
                return;
            }

            foreach (var item in lbIzquierda.Items)
            {
                if (item.ToString().ToLower() == nuevoNombre.ToLower())
                {
                    MessageBox.Show("El nombre ya existe en la lista.");
                    return;
                }
            }

            lbIzquierda.Items.Add(nuevoNombre);
            txtNombres.Text = "";
        }
        private void btnPasar_Click(object sender, EventArgs e)
        {
            if (lbIzquierda.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un nombre de la lista.");
                return;
            }

            foreach (var item in lbPersonas2.Items)
            {
                if (lbIzquierda.SelectedItem.ToString() == item.ToString()) /// en esta validacion, chequeamos de no agregar un item repetido el el otro ListBox
                {
                    MessageBox.Show("Este nombre ya se encuentra en esta lista");
                    return;
                }
            }

            lbPersonas2.Items.Add(lbIzquierda.SelectedItem);
            lbIzquierda.Items.Remove(lbIzquierda.SelectedItem);
        }
        private void btnPasarTodo_Click(object sender, EventArgs e)
        {
            foreach (var item in lbIzquierda.Items)
            {
                if (!(lbPersonas2.Items.Contains(item)))
                { /// en esta validacion, corroboramos que no se agreguen elementos que ya estaban en la otra lista, y los filtra

                    lbPersonas2.Items.Add(item);

                }
            }
            lbIzquierda.Items.Clear();
        }

    }
}
