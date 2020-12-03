using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class factura : Form
    {
        public factura()
        {
            InitializeComponent();
            combocomplete();
            idf();
        }

        private string fecha;
        private int datafecha;
        private readonly int id;
        private readonly conectar conect = new conectar();

        private void combocomplete()
        {
            conect.Abrir();
            SqlCommand command = new SqlCommand("select Nombre from Inventario", conect.SqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["Nombre"].ToString());
            }
            conect.Cerrar();
        }

        private void idf()
        {
            try
            {
                conect.Abrir();
                SqlCommand command = new SqlCommand("select idfactura from Factura", conect.SqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = Convert.ToString(Convert.ToInt64(reader["idfactura"].ToString()) + 1);
                }
                conect.Cerrar();
            }
            catch (Exception es)
            {
                MessageBox.Show($"error {es}");
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conect.Abrir();
                SqlCommand sqlCommand = new SqlCommand($"select Precio,FechaExp from Inventario where Nombre='{comboBox1.Text}'", conect.SqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    textBox4.Text = reader["Precio"].ToString();
                    fecha = reader["FechaExp"].ToString();

                    datafecha = DateTime.Compare(Convert.ToDateTime(fecha.ToString()), Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")));
                    if (datafecha > 0)
                    {
                        label5.Text = $"Expira el {reader["FechaExp"]}";
                    }
                    else
                    {
                        label5.Text = $"Expiro el {reader["FechaExp"]}";
                    }
                }
            }
            catch (Exception es) { MessageBox.Show($"error {es}"); }
            conect.Cerrar();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            combocomplete();
        }

        private void buscar()
        {
            try
            {
                conect.Abrir();
                SqlCommand mySqlCommand = new SqlCommand($"SELECT idfactura as 'ID',Nombre_cliente as 'Nombre del Cliente',Nombre_producto as 'Productos',Precio,Cantidad,Monto,Fecha_del_Registro FROM Factura where idfactura ='{textBox1.Text}'", conect.SqlConnection);
                SqlDataAdapter sqlData = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                sqlData.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                conect.Cerrar();
            }
            catch (Exception es)
            {
                MessageBox.Show($"ERROR: {es}");
                conect.Cerrar();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que deseas agregar a factura?","info",MessageBoxButtons.YesNo);
            if (result == DialogResult.OK)
            {
                try
                {
                    conect.Abrir();
                    SqlCommand sqlCommand = new SqlCommand($"INSERT INTO Factura (idfactura,Nombre_cliente ,Nombre_producto,Precio,Cantidad,Monto,Fecha_del_Registro ) VALUES ('{textBox1.Text}', '{textBox2.Text}','{comboBox1.Items}','{textBox4.Text}','{textBox4.Text}','{textBox5.Text}','{DateTime.Now.ToString("dd/MM/yyyy")}')", conect.SqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Reguistro Exitoso");
                    conect.Cerrar();
                }
                catch (Exception es)
                {
                    MessageBox.Show($"ERROR: {es}");
                    conect.Cerrar();
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
            }
            else
            {
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox3.Text));
            }
        }
    }
}
