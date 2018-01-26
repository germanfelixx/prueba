using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pymasa
{
    public partial class Inicio : Form
    {
        int idee = 0;
        String Nombre = "null";
        String Ap_paterno;
        String Ap_materno;
        String Departamento;
        String Sueldo;
        String FecNac;
        public Inicio()
        {
            
            InitializeComponent();
           
        }
        conexionbd sql = new conexionbd();
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txt_sueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar>=32 && e.KeyChar<=47 )||e.KeyChar>=58 && e.KeyChar<=255)
            {
                e.Handled = true;
                return;
            }
        }


        private void Sololetras(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96)|| (e.KeyChar >= 123 && e.KeyChar <= 255)||( e.KeyChar==32))
            {
                e.Handled = true;
                return;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            dgv.DataSource = sql.MostrarDatos();
        }

        private void Obtenerid(object sender, DataGridViewCellEventArgs e)
        {
            
                DataGridViewRow fila = dgv.Rows[e.RowIndex];
                idee = Convert.ToInt32(fila.Cells[0].Value);
                Nombre = Convert.ToString(fila.Cells[1].Value);
                Ap_paterno = Convert.ToString(fila.Cells[2].Value);
                Ap_materno = Convert.ToString(fila.Cells[3].Value);
                Departamento = Convert.ToString(fila.Cells[5].Value);
                Sueldo = Convert.ToString(fila.Cells[6].Value);
                FecNac = Convert.ToString(fila.Cells[4].Value);
            
        }

        private void Cmd_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar?", "Confirmación", MessageBoxButtons.YesNo,
   MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                if (sql.Eliminar(idee.ToString()))
                {
                    MessageBox.Show("Datos eliminados");
                    dgv.DataSource = sql.MostrarDatos();
                }
                else MessageBox.Show("No se han podido eliminar los datos");
            }
           
        }

        private void Cmd_nuevo_Click(object sender, EventArgs e)
        {

            AdmEmpleado AdmEmpleados = new AdmEmpleado();
            AdmEmpleados.tipo.Text = "0";
            AdmEmpleados.Show();
            this.Visible = false;
        }

        private void Cmd_modificar_Click(object sender, EventArgs e)
        {
            if (Nombre != "null")
            {
                AdmEmpleado AdmEmpleados = new AdmEmpleado();
                AdmEmpleados.tipo.Text = "1";
                AdmEmpleados.Txt_id.Text = idee.ToString();
                AdmEmpleados.Txt_nombre.Text = Nombre;
                AdmEmpleados.Txt_appaterno.Text = Ap_paterno;
                AdmEmpleados.Txt_apmaterno.Text = Ap_materno;
                AdmEmpleados.Cbx_departamento.Text = Departamento;
                AdmEmpleados.Txt_sueldo.Text = Sueldo;
                AdmEmpleados.Txt_fecha.Value = Convert.ToDateTime(FecNac);
                AdmEmpleados.Show();
                this.Visible = false;
            }
            else { MessageBox.Show("Selecciona un empleado e intenta de nuevo"); }
            
        }
    }
}
