using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Ejercicio_propuesto
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ARTI\\SQLEXPRESS;Initial Catalog=Ventas;Integrated Security=True";
            string selectSQL = "SELECT * FROM Productos";
            //Iniciamos la conexion
            SqlConnection conexion = new SqlConnection(connectionString);
            //Ejecutamos la consulta SQL
            SqlCommand comando = new SqlCommand(selectSQL, conexion);
            //Almacenamos los datos en un dataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            // llenando el dataset
            DataSet ventas = new DataSet();
            adapter.Fill(ventas, "clientes");
            // enlazar el gridview
            GridView1.DataSource = ventas;
            GridView1.DataBind();
        }
    }
}