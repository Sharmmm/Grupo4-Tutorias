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
    public partial class Login : Form
    {
        public string usuario;
        public string clave;
        public Login()
        {
            InitializeComponent();
            buttonIngresar.Focus();
            
        }

        public bool logins(string _usuario,string _clave)
        {
            try
            {

                using (SqlConnection conexion = new SqlConnection("Server=tcp:cuatro.database.windows.net,1433;Initial Catalog=Tutorias;Persist Security Info=False;User ID=cuatro;Password=Tutorias1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
                {
                    conexion.Open();
                    //_usuario = txtusuario.Text;
                    //_clave = txtcontraseña.Text;

                    using (SqlCommand cmd = new SqlCommand("SELECT * from Logins  WHERE Logins.Usuario='" + _usuario + "' AND Logins.Contraseña='" + _clave + "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            //MessageBox.Show("Login exitoso.");
                            obtenerusuario();
                            Close();
                            return true;
                            
                        }
                        else
                        {
                           // MessageBox.Show("Datos incorrectos.");
                            txtusuario.Text = "";
                            txtcontraseña.Text = "";
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }
        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            usuario = txtusuario.Text;
            clave = txtcontraseña.Text;
            bool v=  logins(usuario,clave);
            if(v==true)
            {
                MessageBox.Show("Login exitoso.");
            }
            else
            {
                MessageBox.Show("ERROR : Ingrese usuario y clave ");
            }
        }
        public string obtenerusuario()
        {
            usuario = txtusuario.Text;
            return usuario;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta opción estara disponible muy pronto :v");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
