using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class FrmMain : Form
    {
        
        private DataSet aDatos;
        public DataSet Datos
        {
            get { return aDatos; }
        }
        public FrmMain()
        {
            InitializeComponent();
            Login test = new Login();
            test.ShowDialog();
            labelUsuario.Text = test.usuario;
            labelCategoriaU.Text = validarcategoria(test.usuario);
            
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            PantallaOk();
        }
        public void PantallaOk()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        public void selectedBotons(Bunifu.Framework.UI.BunifuFlatButton sender)
        {
           
            btnEstudiantes.Textcolor = Color.WhiteSmoke;
           

            sender.selected = true;

            if (sender.selected)
            {
                sender.Textcolor = Color.FromArgb(98, 195, 140);
            }
        }
        private void btnEstudiantes_Click(object sender,EventArgs e)
        {
            AbrirFormulriosEnWrapper(new FrmEstudiante());
        }
        private void btnDocentes_Click(object sender, EventArgs e)
        {
            AbrirFormulriosEnWrapper(new FrmDocente());
        }
        private Form FormActive = null;
        private void AbrirFormulriosEnWrapper(Form FormHijo)
        {
            if (FormActive != null)
                FormActive.Close();
            FormActive = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.Dock = DockStyle.Fill;
            Wrapper.Controls.Add(FormHijo);
            Wrapper.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new FrmInformation("¿Desea cerrar sesión?");
            resultado = mensaje.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Application.Exit();
                this.Hide();
            }
        }

        private void btnFicha_Click(object sender, EventArgs e)
        {
            AbrirFormulriosEnWrapper(new FrmFicha());
        }
        private void btnTutoria_Click(object sender, EventArgs e)
        {
            AbrirFormulriosEnWrapper(new FrmTutoria());
        }

        private void btnTutorados_Click(object sender, EventArgs e)
        {
            AbrirFormulriosEnWrapper(new FrmRegistro());
        }

        public DataSet EjecutarSelect(string pConsulta)
        {//-- Método para ejecutar consultas del tipo SELECT

            using (SqlConnection conexion = new SqlConnection("Server=tcp:cuatro.database.windows.net,1433;Initial Catalog=Tutorias;Persist Security Info=False;User ID=cuatro;Password=Tutorias1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                conexion.Open();
                SqlDataAdapter a = new SqlDataAdapter();
                using (SqlCommand cmd = new SqlCommand(pConsulta, conexion)) ;
                a.SelectCommand = new SqlCommand(pConsulta, conexion);
                aDatos = new DataSet();
                // aAdaptador.Fill(aDatos);
                a.Fill(aDatos);
                conexion.Close();
            }
            return aDatos;
        }
        public string ValorAtributo(string pNombreCampo)
        {//-- Recupera el valor de un atributo del dataset
            if (Datos.Tables[0].Rows.Count > 0)
            {
                return Datos.Tables[0].Rows[0][pNombreCampo].ToString();
            }
            else
                return "";
        }
        public string validarcategoria(String pusuario)
        {
            string Datos;
            string Consulta = "select * from Logins where  Usuario='" + pusuario + "'";
            EjecutarSelect(Consulta);
            Datos = ValorAtributo("CategoriaLogin");
            return Datos;
        }
        public bool ValidarAcceso()
        {
            bool categoria=false;
            if (labelCategoria.Text == "Estudiante")
            {
                categoria = true;
            }
            /*if (labelCategoria.Text == "Contratado")
            {
                categoria = true;
            }*/
            return  categoria;
        }

        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
