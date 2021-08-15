using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class FrmMantRegistro : Form
    {
        public bool Update = false;
        E_Registro entities = new E_Registro();
        N_Registro business = new N_Registro();
        public FrmMantRegistro()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Update == false)
            {
                try
                {
                    entities.IdTutoria = Convert.ToInt32(textIdTutoria.Text);
                    entities.IdEstudiante = Convert.ToInt32(textIdEstudiante.Text);

                    business.CreatingTutorado(entities);
                    FrmSuccess.confirmacionForm("TUTORADO GUARDADO");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar la categoria " + ex);
                }
            }
            if (Update == true)
            {
                try
                {
                    entities.IdTutoria = Convert.ToInt32(textIdTutoria.Text);
                    entities.IdEstudiante = Convert.ToInt32(textIdEstudiante.Text);

                    business.UpdatingTutorado(entities);

                    //     successView.confirmForm("PRODUCTO EDITADO");
                    FrmSuccess.confirmacionForm("TUTORADO EDITADO");
                    Close();

                    Update = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar la categoria " + ex);
                }
            }
        }

        
    }
}
