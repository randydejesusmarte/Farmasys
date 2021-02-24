using System;
using System.Windows.Forms;
using WindowsFormsApp1.Datasets;

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
            // TODO: esta línea de código carga datos en la tabla 'farmaciaDataSet1.usuarios' Puede moverla o quitarla según sea necesario.
            usuariosTableAdapter.Fill(farmaciaDataSet1.usuarios);

            reportViewer1.RefreshReport();
        }
    }
}
