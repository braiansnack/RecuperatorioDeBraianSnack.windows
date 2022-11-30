using ParcialDeBraianSnack.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialDeBraianSnack
{
    public partial class frmCubo : Form
    {
        public frmCubo()
        {
            InitializeComponent();
        }
        private Cubo cubo;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarComboColores();
        }

        private void CargarComboColores()
        {
            RellenoComboBox.DataSource = Enum.GetValues(typeof(Relleno));
            RellenoComboBox.SelectedIndex = 0;
        }

        public  Cubo GetCubo()
        {
            return cubo;
        }

    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TrazoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (cubo==null)
                {
                    cubo = new Cubo();
                }
                cubo.Arista = int.Parse(AristaTextBox.Text);
                cubo.Relleno = (Relleno)RellenoComboBox.SelectionLength;
                if (ContinuoTrazoButton.Checked)
                {
                    cubo.Trazo = Trazo.Continuo;
                }
                else if (RayasTrazoButton.Checked)
                {
                    cubo.Trazo = Trazo.Rayas;
                }
                else
                {
                    cubo.Trazo = Trazo.Puntos;
                }
                if (!cubo.Validar())
                {
                    DialogResult = DialogResult.OK;
                }
                errorProvider1.SetError(AristaTextBox, "La arista debe ser positiva");
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(AristaTextBox.Text, out int arista))
            {
                valido = false;
                errorProvider1.SetError(AristaTextBox, "Arista mal ingresada");
            }
            return valido;
        }

        public void SetCubo(Cubo cubo)
        {
            this.cubo = cubo;
        }
    }
}
