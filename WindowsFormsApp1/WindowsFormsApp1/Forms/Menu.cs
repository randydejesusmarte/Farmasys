using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Reportes;

namespace WindowsFormsApp1
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }
        internal string puesto;
        internal string sexo;
        internal string nombre;
        internal string switc;
        private int suit = 0;
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Filtro()
        {
            if(puesto == "Cajero")
            {
                btfact.Enabled = false;
            }
            else if(puesto == "Vendedor")
            {
                btinventario.Enabled = false;
                button1.Enabled = false;
            }
        }


        private void Inicio_Load(object sender, EventArgs e)
        {
            Filtro();
            button1.Text = puesto;
            welcom.Visible = true;
            if (sexo == "Hombre")
            {
                switc = "Biemvenido señor\n";
            }
            else if (sexo == "Mujer")
            {
                switc = "Biemvenida señora\n";
            }
            welcom.Text = switc + nombre;
            screen.Controls.Clear();
        }

        public void FormH(Form form)
        {
            screen.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            screen.Controls.Add(form);
            screen.Tag = form;
            form.Show();
        }

        private void Piclose_Click(object sender, EventArgs e) => Application.Exit();

        private void Pisize_Click(object sender, EventArgs e)
        {
            switch (suit)
            {
                case 0:
                    WindowState = FormWindowState.Maximized;
                    pisize.Image = Properties.Resources.icons8_restore_window_96px;
                    suit = 1;
                    break;
                default:
                    WindowState = FormWindowState.Normal;
                    pisize.Image = Properties.Resources.icons8_maximize_window_96px;
                    suit = 0;
                    break;
            }
        }

        private void Pimini_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void Drager_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 274, 61458, 0);
        }

        private void Btinicio_Click(object sender, EventArgs e)
        {
            welcom.Visible = true;
            screen.Controls.Clear();
        }

        private void Btinventario_Click(object sender, EventArgs e)
        {
            FormH(new Inventario());
            welcom.Visible = false;
        }

        private void Btbuscar_Click(object sender, EventArgs e)
        {
            FormH(new Buscar());
            welcom.Visible = false;
        }

        private void Btfact_Click(object sender, EventArgs e)
        {
            FormH(new factura());
            welcom.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FormH(new MENU());
            welcom.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormH(new Caja());
            welcom.Visible = false;
        }
    }
}
