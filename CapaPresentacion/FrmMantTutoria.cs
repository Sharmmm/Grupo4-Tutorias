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
    public partial class FrmMantTutoria : Form
    {
        public bool Update = false;
        E_Tutoria entities = new E_Tutoria();
        N_Tutoria business = new N_Tutoria();
        public FrmMantTutoria()
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
                    entities.IdDocente = Convert.ToInt32(textIdDocente.Text);
                    entities.Horario = textHorario.Text;

                    business.CreatingTutoria(entities);
                    FrmSuccess.confirmacionForm("TUTOR REGISTRADO");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar Tutor ");
                }
            }
            if (Update == true)
            {
                try
                {
                    entities.IdTutoria = Convert.ToInt32(textId.Text);
                    entities.IdDocente = Convert.ToInt32(textIdDocente.Text);
                    entities.Horario = textHorario.Text;

                    business.UpdatingTutoria(entities);

                    //     successView.confirmForm("PRODUCTO EDITADO");
                    FrmSuccess.confirmacionForm("TUTORIA EDITADA");
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

