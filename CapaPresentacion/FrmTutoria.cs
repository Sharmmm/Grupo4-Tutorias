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
    public partial class FrmTutoria : Form
    {
        N_Tutoria oTutoria = new N_Tutoria();
        public FrmTutoria()
        {
            InitializeComponent();
            MostrarTablaTutoria();
            OcultarMoverAncharColumnas();
        }
        public void OcultarMoverAncharColumnas()
        {
            TablaTutoria.Columns[0].DisplayIndex = 6;//0
            TablaTutoria.Columns[1].DisplayIndex = 6;//1

        }
        public void MostrarTablaTutoria()
        {
            N_Tutoria oTutoria = new N_Tutoria();
            TablaTutoria.DataSource = oTutoria.ListingTutorias();
        }
        public void BuscarTutoria(string search)
        {
            N_Tutoria oTutoria = new N_Tutoria();
            TablaTutoria.DataSource = oTutoria.SearchingTutorias(search);

        }
        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarTutoria(textBuscar.Text);
        }
        private void btnAgregarTutoria_Click(object sender, EventArgs e)
        {
            FrmMantTutoria frm = new FrmMantTutoria();
            frm.ShowDialog();
            frm.Update = false;
            MostrarTablaTutoria();
        }

        private void TablaTutoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TablaTutoria.Rows[e.RowIndex].Cells["eliminar"].Selected)
            {
                Form message = new FrmInformation("¿ESTAS SEGURO DE ELIMINAR EL DOCENTE?");
                DialogResult result = message.ShowDialog();

                if (result == DialogResult.OK)
                {
                    int delete = Convert.ToInt32(TablaTutoria.Rows[e.RowIndex].Cells[2].Value.ToString());
                    oTutoria.DeletingTutoria(delete);
                    FrmSuccess.confirmacionForm("ELIMINADO");
                    MostrarTablaTutoria();
                    // ShowTotal();
                }
            }
            else if (TablaTutoria.Rows[e.RowIndex].Cells["editar"].Selected)
            {
                FrmMantTutoria frm = new FrmMantTutoria();
                frm.Update = true;
                frm.textId.Text = TablaTutoria.Rows[e.RowIndex].Cells["IdTutoria"].Value.ToString();
                frm.textIdDocente.Text = TablaTutoria.Rows[e.RowIndex].Cells["IdDocente"].Value.ToString();
                frm.textHorario.Text = TablaTutoria.Rows[e.RowIndex].Cells["Horario"].Value.ToString();
                
                frm.ShowDialog();
                MostrarTablaTutoria();
                //ShowTotal();
            }
        }
    }
}
