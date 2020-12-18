using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Reportes.Forms
{
    public partial class RUsuarios : Form
    {
        public RUsuarios()
        {
            InitializeComponent();
        }

        private void Rusuarios_Load(object sender, EventArgs e)
        {

            reportViewer1.RefreshReport();
        }
    }
}
