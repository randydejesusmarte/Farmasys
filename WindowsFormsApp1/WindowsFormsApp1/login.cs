using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private readonly conectar conectar = new conectar();

        private void btn_Click(object sender, EventArgs e)
        {
            enter();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new usuario().ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AboutBox1().ShowDialog();
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                enter();
            }
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                enter();
            }
        }
        private void enter()
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("Falto Ingresar el Nombre", "Alvertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtname.Focus();

            }
            else if (txtpass.Text == "")
            {
                MessageBox.Show("Falto Ingresar el de la contraseña", "Alvertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtpass.Focus();
            }
            else if (txtname.Text == "" && txtpass.Text == "")
            {
                MessageBox.Show("Falto Ingresar los Datos del usuario", "Alvertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtpass.Focus();
            }
            else
            {
                try
                {
                    conectar.Abrir();
                    SqlCommand loger = new SqlCommand($"select count(*) FROM usuarios WHERE uname='{txtname.Text.Trim().ToLower()}' and pass='{txtpass.Text}' and estado=1;", conectar.SqlConnection);
                    int users = int.Parse(loger.ExecuteScalar().ToString());
                    switch (users)
                    {
                        case 0:
                            MessageBox.Show("El usuario no existe");
                            break;
                        case 1:
                            inicio inicio = new inicio();
                            SqlCommand sexquery = new SqlCommand($"select nombre, sexo, puesto from usuarios where uname='{txtname.Text.Trim().ToLower()}';", conectar.SqlConnection);
                            SqlDataReader sqlData = sexquery.ExecuteReader();
                            if (sqlData.Read())
                            {
                                inicio.puesto = sqlData["puesto"].ToString();
                                inicio.nombre = sqlData["nombre"].ToString();
                                inicio.sexo = sqlData["sexo"].ToString();
                            }
                            inicio.Show();
                            Hide();
                            break;
                        case 3:
                            MessageBox.Show("El Usuario es redundante.\n Favor comunicarse con el Administrador");
                            break;
                        default:
                            MessageBox.Show("incorrecto");
                            break;
                    }
                    conectar.Cerrar();
                }
                catch (Exception es)
                {
                    MessageBox.Show($"Error: {es.Message}");
                    conectar.Cerrar();
                }
            }
        }
    }
}
