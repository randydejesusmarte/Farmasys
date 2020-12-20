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
            // TODO: esta línea de código carga datos en la tabla 'farmaciaDataSet2.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.farmaciaDataSet2.usuarios);

            reportViewer1.RefreshReport();
        }
    }
}
