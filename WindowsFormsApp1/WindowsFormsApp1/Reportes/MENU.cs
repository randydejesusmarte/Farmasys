using System;
using System.Windows.Forms;
using WindowsFormsApp1.Reportes.Forms;

namespace WindowsFormsApp1.Reportes
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new RFactura().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new RImventario().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new RUsuarios().Show();
        }
    }
}
