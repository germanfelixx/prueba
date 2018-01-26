using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pymasa
{
    class conexionbd
    {//conexion base de datos
        private SqlConnection conexion = new SqlConnection("Data Source = PERRY\\SQLSERVER; Initial Catalog = PRUEBA; Integrated Security = true");
        private DataSet ds;
        SqlDataReader dr;
        public DataTable MostrarDatos()
        {//Llenado de tabla principal
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select Clave_emp as Clave,Nombre,Ap_paterno as 'Apellido Paterno',Ap_materno as 'Apellido Materno',FecNac as 'Fecha Nacimiento',Departamentos.descripcion as Departamento,Sueldo from Empleados INNER join Departamentos on (Empleados.Departamento=Departamentos.Puesto)", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        //insertar empleado
        public bool Insertar(string cadena)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(cadena,conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }
        //Eliminar empleado
        public bool Eliminar(string id)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("delete from Empleados where Clave_emp = {0}", id), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }
        //Modificar empleado
        public bool Actualizar(string cadena)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(cadena, conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }
        //llenado de combo
        public void llenarItems(ComboBox cb)
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("Select descripcion from departamentos", conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["descripcion"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el ComboBox: " + ex.ToString());
            }
        }
    }



}
