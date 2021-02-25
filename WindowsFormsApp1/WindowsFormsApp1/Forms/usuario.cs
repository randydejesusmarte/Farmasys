using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class usuario : Form
    {
        public usuario()
        {
            InitializeComponent();
        }

        private readonly conectar conectar = new conectar();

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            conectar.Abrir();
            SqlCommand sqlCommand = new SqlCommand($"select count(*) from usuarios where pass='{adminpass.Text}' and puesto='Administrador'", conectar.SqlConnection);
            int s = int.Parse(sqlCommand.ExecuteScalar().ToString());
            switch (s)
            {
                case 0:
                    txtnombre.Enabled = txtnickname.Enabled = txtpass.Enabled = csexo.Enabled = cpuesto.Enabled = pictureBox1.Enabled = false;
                    break;
                case 1:
                    txtnombre.Enabled = txtnickname.Enabled = txtpass.Enabled = csexo.Enabled = cpuesto.Enabled = pictureBox1.Enabled = true;
                    break;
            }
            conectar.Cerrar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("El nuevo usuario sera agregado.\n¿Seguro que deseas registrarlo?", "Info", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conectar.Abrir();
                    SqlCommand sqlCommand = new SqlCommand($"Insert Into usuarios (uname,pass,nombre,sexo,puesto,estado) values ('{txtnickname.Text}','{txtpass.Text}','{txtnombre.Text}','{csexo.Text}','{cpuesto.Text}','1')", conectar.SqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("usuario reguistrado");
                    txtnombre.Text = txtnickname.Text = txtpass.Text = csexo.Text = cpuesto.Text = "";
                    conectar.Cerrar();
                }
                catch (Exception es)
                {
                    MessageBox.Show($"error: {es.Message}");
                    conectar.Cerrar();
                }
            }
        }
    }
}
