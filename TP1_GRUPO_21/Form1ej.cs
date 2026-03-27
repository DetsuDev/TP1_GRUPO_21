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
        FormPrincipal mainForm; // Hago referencia al formulario principal

        public Form1ej(FormPrincipal mainForm) // Recibo el formulario principal como parametro para usarlo cuando se cierre este formulario
        {
            InitializeComponent();
            this.mainForm = mainForm; // Guardo la referencia en una variable
        }

        private void Form1ej_FormClosed(object sender, FormClosedEventArgs e) // Al momento de cerrar el formulario del ej1
        {
            mainForm.Show(); // Muestro el formulario principal
        }
    }
}
