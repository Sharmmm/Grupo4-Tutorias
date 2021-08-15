﻿using System;
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
    public partial class FrmMantFicha : Form
    {
        public bool Update = false;
        E_Ficha entities = new E_Ficha();
        N_Ficha business = new N_Ficha();
        public FrmMantFicha()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FrmMantFicha_Load(object sender, EventArgs e)
        {

        }
        public string Encriptar(string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Update == false)
            {
                try
                {
                    entities.IdTutoria = Convert.ToInt32(textIdTutoria.Text);
                    entities.IdEstudiante = Convert.ToInt32(textIdEstudiante.Text);
                    entities.NroCelular = textNroCelular.Text;
                    entities.Direccion = textDireccion.Text;
                    entities.Email = textEmail.Text;
                    entities.PersonaReferencia = textPersonaReferencia.Text;
                    entities.CelularReferencia = textCelularReferencia.Text;
                    entities.Fecha = dtpFecha.Value.ToString("yyyy-MM-dd");
                    entities.TipoTutoria = comboBoxTipoTutoria.Text;
                    entities.Descripcion = Encriptar(richTextBoxDescripcion.Text);

                    business.CreatingFicha(entities);
                    FrmSuccess.confirmacionForm("FICHA DE TUTORIA GUARDADA");
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
                   // entities.IdFichaTutoria = Convert.ToInt32(textId.Text);
                    entities.IdTutoria = Convert.ToInt32(textIdTutoria.Text);
                    entities.IdEstudiante = Convert.ToInt32(textIdEstudiante.Text);
                    entities.NroCelular = textNroCelular.Text;
                    entities.Direccion = textDireccion.Text;
                    entities.Email = textEmail.Text;
                    entities.PersonaReferencia = textPersonaReferencia.Text;
                    entities.CelularReferencia = textCelularReferencia.Text;
                    entities.Fecha = dtpFecha.Value.ToString("yyyy-MM-dd");
                    entities.TipoTutoria = comboBoxTipoTutoria.Text;
                    entities.Descripcion = Encriptar(richTextBoxDescripcion.Text);

                    business.UpdatingFicha(entities);

                    //     successView.confirmForm("PRODUCTO EDITADO");
                    FrmSuccess.confirmacionForm("FICHA DE TUTORIA EDITADA");
                    Close();

                    Update = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar la categoria" + ex);
                }
            }
        }
    }
}