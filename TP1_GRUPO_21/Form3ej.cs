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
    public partial class Form3ej : Form
    {
        FormPrincipal mainForm;
        public Form3ej(FormPrincipal mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btnSelecciones_Click(object sender, EventArgs e)
        {
            string sexo = rbFemenino.Checked ? "Femenino" : "Masculino";
            string estadoCivil = rbCasado.Checked ? "Casado" : "Soltero";

            lblResultado.Text = "Usted seleccionó los siguientes elementos:" +
                        "\nSexo: " + sexo +
                        "\nEstado Civil: " + estadoCivil;
        }

        private void Form3ej_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}
