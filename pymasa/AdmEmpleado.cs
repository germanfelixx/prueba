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
    public partial class AdmEmpleado : Form
    {
        
        public AdmEmpleado()
        {
            InitializeComponent();
        }
        //base de datos
        conexionbd sql = new conexionbd();

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void CMD_cancelar_Click(object sender, EventArgs e)
        {//cancelar y enlazar al otro formulario
            Inicio abrir = new Inicio();
            abrir.Show();
            this.Close();
        }
        private void CMD_guardar_Click(object sender, EventArgs e)
        {
            if (Txt_nombre.Text == "" || Txt_appaterno.Text == "" || Txt_apmaterno.Text == "" || Txt_sueldo.Text == "") { MessageBox.Show("Rellena todos los campos para continuar"); }
            else
            {
                string fecha = Txt_fecha.Value.ToString("MM-dd-yyyy");
                string inde = Cbx_departamento.SelectedIndex.ToString();
                if (tipo.Text == "0")
                { //agregar nuevo empleado

                    string agregar = "insert into Empleados (Nombre,Ap_paterno,Ap_materno,FecNac,Departamento,sueldo) values ('" + Txt_nombre.Text + "','" + Txt_appaterno.Text + "','" + Txt_apmaterno.Text + "','" + fecha + "','" + inde + "','" + Txt_sueldo.Text + "')";
                    if (sql.Insertar(agregar.ToString()))
                    {
                        MessageBox.Show("Empleado guardado satisfactoriamente");
                        Inicio abrir = new Inicio();
                        abrir.Show();
                        this.Close();
                    }
                    else MessageBox.Show("No se han podido insertar los datos");
                }
                else
                {
                    //modificar empleado
                    string agregar2 = "update Empleados set Nombre ='" + Txt_nombre.Text + "', Ap_Paterno ='" + Txt_appaterno.Text + "',Ap_Materno ='" + Txt_apmaterno.Text + "',FecNac='" + fecha + "',Departamento = '" + inde + "',Sueldo = '" + Txt_sueldo.Text + "' Where Clave_emp ='" + Txt_id.Text + "'";
                    MessageBox.Show(agregar2);
                    if (sql.Actualizar(agregar2.ToString()))
                    {
                        MessageBox.Show("Datos actualizados");
                        Inicio abrir = new Inicio();
                        abrir.Show();
                        this.Close();
                    }
                    else MessageBox.Show("No se han podido actualizar los datos");

                }
            }
        }

        private void CMD_cancelar_Click_1(object sender, EventArgs e)
        {//cancelar y enlazar al otro formulario
            Inicio abrir = new Inicio();
            abrir.Show();
            this.Close();
        }

        private void AdmEmpleado_Load(object sender, EventArgs e)
        {
           //llenado de combobox
            sql.llenarItems(Cbx_departamento);
        }

        private void Txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void sololetras(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255) )
            {
                e.Handled = true;
                return;
            }
        }

        private void solonumeros(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255)||e.KeyChar==47)
            {
                e.Handled = true;
                return;
            }
        }
    }
}
