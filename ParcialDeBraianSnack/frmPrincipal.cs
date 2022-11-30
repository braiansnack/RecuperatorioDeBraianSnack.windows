using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcialDeBraianSnack.Datos;
using ParcialDeBraianSnack.Entidades;

namespace ParcialDeBraianSnack
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmCubo frm = new frmCubo() { Text = "Agregar nueva arista" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            Cubo cubo = frm.GetCubo();
            repositorio.Agregar(cubo);
            DataGridViewRow r = ConstuirFila();
            SetearFila(r, cubo);
            AgregarFila(r);
            MostrarCantidad(repositorio.GetCantidad());

        }

        private void MostrarCantidad(int cantidad)
        {
            CantidadTextBox.Text = cantidad.ToString();
        }

        private DataGridViewRow ConstuirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Cubo cubo)
        {
            r.Cells[colArea.Index].Value = cubo.Arista;
            r.Cells[colColor.Index].Value = cubo.Relleno.ToString();
            r.Cells[colTrazo.Index].Value = cubo.Trazo.ToString();
            r.Cells[colArea.Index].Value = cubo.GetArea();

            r.Tag = cubo;

        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var cubo in lista)
            {
                var r = ConstuirFila();
                SetearFila(r, cubo);
                AgregarFila(r);
            }
        }


        private RepositorioDeCubos repositorio;
        private List<Cubo> lista;
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            repositorio = new RepositorioDeCubos();
           
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }

            var r = dgvDatos.SelectedRows[0];
            Cubo cubo = (Cubo)r.Tag;
            DialogResult dr = MessageBox.Show($"¿Desea borrar la arista de area {cubo.Arista}?",
                "Confirmar Operación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            repositorio.Borrar(cubo);
            dgvDatos.Rows.Remove(r);
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            Cubo cubo = (Cubo)r.Tag;
            frmCubo frm = new frmCubo() { Text = "Editar Cubo" };
            frm.SetCubo(cubo);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {

                return;
            }

            cubo = frm.GetCubo();
            repositorio.Editar(cubo);
            SetearFila(r, cubo);
        }

        private void tsbFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void tsbRefrescar_Click(object sender, EventArgs e)
        {
            lista = repositorio.GetLista();
            MostrarDatosEnGrilla();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {

        }

        private void AscendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.GetListaOrdenadaAsc();
            MostrarDatosEnGrilla();
        }

        private void DescendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.GetListaOrdenadaDesc();
            MostrarDatosEnGrilla();
        }
    }
}
