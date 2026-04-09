using System;
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

        }

        private void Form3ej_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}
