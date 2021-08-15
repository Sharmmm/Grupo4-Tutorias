using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidades;
using System.Data;

namespace CapaDatos
{
    public class D_Registro
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public DataTable ListTutorados()
        {
            DataTable table = new DataTable();
            SqlDataReader readRows;
            SqlCommand cmd = new SqlCommand("SP_LISTARTUTORADO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            readRows = cmd.ExecuteReader();
            table.Load(readRows);

            readRows.Close();
            conexion.Close();

            return table;
        }
        public DataTable SearchTutorados(E_Registro tutorado)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_BUSCARTUTORADO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", tutorado.Search);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;
        }

        public void DeleteTutorado(int Id)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARTUTORADO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDESTUDIANTE", Id);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void CreateTutorado(E_Registro tutorado)
        {

            SqlCommand cmd = new SqlCommand("SP_INSERTARTUTORADO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDTUTORIA", tutorado.IdTutoria);
            cmd.Parameters.AddWithValue("@IDESTUDIANTE", tutorado.IdEstudiante);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void UpdateTutorado(E_Registro tutorado)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARTUTORADO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDTUTORIA", tutorado.IdTutoria);
            cmd.Parameters.AddWithValue("@IDESTUDIANTE", tutorado.IdEstudiante);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

    }
}
