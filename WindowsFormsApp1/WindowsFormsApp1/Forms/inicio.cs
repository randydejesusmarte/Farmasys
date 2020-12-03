using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }
        public string sexo;
        public string nombre;
        public string switc;
        private int suit = 0;
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void inicio_Load(object sender, EventArgs e)
        {
            welcom.Visible = true;
            if (sexo == "Hombre")
            {
                switc = "Biemvenida señor\n";
            }
            else if (sexo == "Mujer")
            {
                switc = "Biemvenida señora\n";
            }
            welcom.Text = switc + nombre;
            screen.Controls.Clear();
        }

        public void formson(object formso)
        {
            if (screen.Controls.Count > 0)
            {
                screen.Controls.Clear();
            }
            Form form = formso as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            screen.Controls.Add(form);
            screen.Tag = form;
            form.Show();
        }

        private void piclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pisize_Click(object sender, EventArgs e)
        {
            if (suit == 0)
            {
                WindowState = FormWindowState.Maximized;
                pisize.Image = Properties.Resources._118_minimize;
                suit = 1;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                pisize.Image = Properties.Resources._123_expand;
                suit = 0;
            }
        }

        private void pimini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void drager_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 274, 61458, 0);
        }

        private void btinicio_Click(object sender, EventArgs e)
        {
            welcom.Visible = true;
            screen.Controls.Clear();
        }

        private void btinventario_Click(object sender, EventArgs e)
        {
            formson(new Inventario());
            welcom.Visible = false;
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {
            formson(new Buscar());
            welcom.Visible = false;
        }

        public void btfact_Click(object sender, EventArgs e)
        {
            formson(new factura());
            welcom.Visible = false;
        }
    }
}
