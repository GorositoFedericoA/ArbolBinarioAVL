using System;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Carpeta;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Agregar Nodos
        private Nodo _raiz;
        private Nodo _seleccionado;

        private Nodo CrearNodo() 
        {
            string nombre = Interaction.InputBox("Ingrese nombre del nodo: ");
            return new Nodo(nombre);
        }
        private void btnAgregarRaiz_Click(object sender, EventArgs e)
        {
            if (_raiz != null) 
            {
                DialogResult r = MessageBox.Show("Se eliminara el árbol actual, desea continuar ?","Consulta",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (r == DialogResult.Yes) _raiz = CrearNodo();
            }
            else 
            {
                _raiz = CrearNodo();
            }
        }

        private void btnAgregarIzquierda_Click(object sender, EventArgs e)
        {
            _raiz.Izquierda = CrearNodo();
        }

        private void btnAgregarDerecha_Click(object sender, EventArgs e)
        {
            _raiz.Derecha = CrearNodo();
        }

        #endregion

        #region Recorrer Nodos
        private void btnPreOrden_Click(object sender, EventArgs e)
        {

        }

        private void btnInOrden_Click(object sender, EventArgs e)
        {

        }

        private void btnPostOrden_Click(object sender, EventArgs e)
        {

        }

        private void btnAmplitud_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Ver Nodos
        #endregion

        #region Altura y Anchura
        #endregion
    }
}
