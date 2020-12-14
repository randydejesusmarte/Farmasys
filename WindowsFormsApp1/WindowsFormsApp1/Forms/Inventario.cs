using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
            update_screen();
        }
        public string cosa;
        private string check;
        private string id;
        private readonly conectar conectar = new conectar();

        public void update_screen()
        {
            try
            {
                conectar.Abrir();
                SqlCommand mySqlCommand = new SqlCommand("SELECT ID,Codigo,Nombre,Descripcion,Precio,Tipo_de_Empaque as 'Tipo de Empaque',Original_o_no,Cantidad,Ubicacion,FechaExp,Fecha_del_Registro FROM Inventario", conectar.SqlConnection);
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter { SelectCommand = mySqlCommand };
                DataTable dataTable = new DataTable();
                SqlDataAdapter.Fill(dataTable);
                BindingSource bindingSource = new BindingSource { DataSource = dataTable };
                dgvmantenimiento.DataSource = bindingSource;
                SqlDataAdapter.Update(dataTable);
                conectar.Cerrar();
            }
            catch (Exception es)
            {
                MessageBox.Show($"ERROR: {es}");
                conectar.Cerrar();
            }
        }
        private void dgvmantenimiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = (sender as DataGridView).CurrentRow;
            id = row.Cells[0].Value.ToString();
            tcodigo.Text = row.Cells[1].Value.ToString();
            txtnom.Text = row.Cells[2].Value.ToString();
            txtdesc.Text = row.Cells[3].Value.ToString();
            txtprecio.Text = row.Cells[4].Value.ToString();
            cbempack.Text = row.Cells[5].Value.ToString();
            check = row.Cells[6].Value.ToString();
            txtcant.Text = row.Cells[7].Value.ToString();
            txtubicacion.Text = row.Cells[8].Value.ToString();
            mtxtfecha.Text = row.Cells[9].Value.ToString();
            if (check == "true")
            {
                cgenerico.Checked = true;
            }
            else if (check == "false")
            {
                cgenerico.Checked = false;
            }
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("El producto sera agregado.\n¿Seguro que deseas guardar?", "Info", MessageBoxButtons.YesNo);
            if (result == DialogResult.OK)
            {
                try
                {
                    conectar.Abrir();
                    SqlCommand sqlCommand = new SqlCommand($"Insert Into Inventario (Codigo,Nombre,Descripcion,Precio,Tipo_de_Empaque,Original_o_no,Cantidad,Ubicacion,FechaExp,Fecha_del_Registro) values ('{tcodigo.Text}','{txtnom.Text}','{txtdesc.Text}','{txtprecio.Text}','{cbempack.Text}','{cgenerico.Checked}','{txtcant.Text}','{txtubicacion.Text}','{mtxtfecha.Text}','{DateTime.Now:dd/MM/yyyy}')", conectar.SqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Producto reguistrado");
                    conectar.Cerrar();
                    update_screen();
                }
                catch (Exception es)
                {
                    MessageBox.Show($"error: {es}");
                    conectar.Cerrar();
                }
            }
        }
        private void btedit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("La descripcion del producto sera modificado.\n¿Seguro que deseas guardar?", "Info", MessageBoxButtons.YesNo);
            if (result == DialogResult.OK)
            {
                try
                {
                    conectar.Abrir();
                    SqlCommand sqlCommand = new SqlCommand($"Update Inventario set codigo='{tcodigo.Text}',nombre='{txtnom.Text}',Descripcion='{txtdesc.Text}',Precio='{txtprecio.Text}',Tipo_de_Empaque='{cbempack.Text}',Original_o_no='{cgenerico.Checked}',Cantidad='{txtcant.Text}',Ubicacion='{txtubicacion.Text}',FechaExp='{mtxtfecha.Text}' where ID={id}", conectar.SqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Producto modificado");
                    conectar.Cerrar();
                    update_screen();
                }
                catch (Exception es)
                {
                    MessageBox.Show($"error: {es}");
                    conectar.Cerrar();
                }
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("El producto sera eliminado.\n¿Seguro que deseas eliminar?", "Info", MessageBoxButtons.YesNo);
            if (result == DialogResult.OK)
            {
                try
                {
                    conectar.Abrir();
                    SqlCommand sqlCommand = new SqlCommand($"delete from Inventario where ID='{id}'", conectar.SqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Producto eliminado");
                    conectar.Cerrar();
                    update_screen();
                }
                catch (Exception es)
                {
                    MessageBox.Show($"error: {es}");
                    conectar.Cerrar();
                }
            }
        }
    }
}
