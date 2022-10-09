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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Consulta cons = new Consulta();
          
            cons.ShowDialog();
            this.Show();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Generamos la instancia hacia Alumnos
            Alumnos alumno = new Alumnos();
            this.Hide();   //Ocultamos el formulario actual 
            alumno.ShowDialog();
            this.Show();
        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carreras docente = new Carreras();
         
            docente.ShowDialog();
            this.Show();
        }

        private void asignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Institucional asig = new Institucional();
           
            asig.ShowDialog();
            this.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta cons = new Consulta();
            
            cons.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Generamos la instancia hacia Alumnos
            Alumnos alumno = new Alumnos();
            this.Hide();   //Ocultamos el formulario actual 
            alumno.ShowDialog();
            this.Show();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Carreras docente = new Carreras();
          
            docente.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Institucional asig = new Institucional();
            this.Hide();
            asig.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

       
       

       

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            De acerca = new De();
           
            acerca.ShowDialog();
            this.Show();
        }

        private void contactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Contacto con = new Contacto();
            
            con.ShowDialog();
            this.Show();

        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Docentes dc = new Docentes();

           dc.ShowDialog();
            this.Show();

        }
    }
}
