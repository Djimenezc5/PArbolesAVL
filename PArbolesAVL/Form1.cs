using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PArbolesAVL.Contenido_Arboles.Arbol_AVL;
using PArbolesAVL.Contenido_Proyectos;

namespace PArbolesAVL
{
    public partial class Form1 : Form
    {
        ArbolAVL arbolProyectos = new ArbolAVL();
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarPBtt_Click(object sender, EventArgs e)
        {
            Proyectos proyectos = new Proyectos();
            proyectos.prioridadproyecto = int.Parse(comboBoxPP.Text);
            proyectos.departamentoProyecto = comboBoxDP.Text;
            proyectos.nombreProyecto = nomPTextBox.Text;
            proyectos.montoProyecto = int.Parse(montoPTextBox.Text);

            arbolProyectos.insertar(proyectos);

            MessageBox.Show("Asignación Realizada");
            comboBoxPP.Text = " ";
            comboBoxDP.Text = " ";
            nomPTextBox.Text = " ";
            montoPTextBox.Text = " ";
            textBox1.Text = " ";
        }

        private void listarBtt_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox1.Text = ArbolAVL.preorden(arbolProyectos.raizArbol());
        }
    }
}
