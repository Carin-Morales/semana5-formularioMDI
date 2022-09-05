using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semana5_formularioMDI
{
    public partial class Carreras : Form
    {
        public Carreras()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos enviados", "Registro de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Carreras_Load(object sender, EventArgs e)
        {

        }
    }
}
