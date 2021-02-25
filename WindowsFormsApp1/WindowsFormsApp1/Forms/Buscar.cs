using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private readonly conectar conectar = new conectar();

        private void btfilter_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            try
            {
                conectar.Abrir();
                SqlCommand mySqlCommand = new SqlCommand($"SELECT idfactura as 'ID', Nombre_cliente as 'Nombre del Cliente', Nombre_producto as 'Productos', Precio, Cantidad, Monto, Fecha_del_Registro FROM Factura where idfactura like '%{txtnom.Text}%' or Nombre_cliente like '%{txtnom.Text}%' or Fecha_del_Registro like '%{txtnom.Text}%';", conectar.SqlConnection);
                SqlDataAdapter sqlData = new SqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                sqlData.Fill(dataTable);
                dgvmantenimiento.DataSource = dataTable;
                conectar.Cerrar();
            }
            catch (Exception es)
            {
                MessageBox.Show($"ERROR: {es.Message}");
                conectar.Cerrar();
            }
        }
        private void Buscar_Load(object sender, EventArgs e)
        {
            buscar();
        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }
    }
}
