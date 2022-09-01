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
    public partial class Institucional : Form
    {
        public Institucional()
        {
            InitializeComponent();
        }

       

        

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "somos una universidad que se adapta a los cambios e innova constantemente para responder a las necesidades actuales y futuras de la sociedad, mediante la docencia, investigacion y proyeccion social.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox2.Text += "Ser una univercidad referente comprometida con los sectores de la sociedad a traves de sus aportes academicos y la consolidacion de las relaciones con sus socios.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
