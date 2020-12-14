using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            this.reportViewer1.RefreshReport();
        }
    }
}
