using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class Regcliente : Form
    {
        public Regcliente()
        {
            InitializeComponent();
            idf();
        }

        private readonly conectar conectar = new conectar();

        private void idf()
        {
            try
            {
                conectar.Abrir();
                SqlCommand command = new SqlCommand("select Id from Clientes", conectar.SqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = Convert.ToString(Convert.ToInt64(reader["Id"].ToString()) + 1);
                }
                conectar.Cerrar();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("El usuario sera agregado.\nseguro que deseas agregarlo?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    conectar.Abrir();
                    SqlCommand command = new SqlCommand("INSERT INTO Clientes (Nom_cli, tel_cli, dir_cli) VALUES ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", conectar.SqlConnection);
                    command.ExecuteNonQuery();
                    conectar.Cerrar();
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.ToString());
                }
            }
        }

        private void lipiart()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
            idf();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("los datos seran limpiados.\nseguro que deseas limpiarlo?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                lipiart();
            }
        }
    }
}
