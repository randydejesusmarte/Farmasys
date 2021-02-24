using System.Windows.Forms;
using WindowsFormsApp1.Datasets;

namespace WindowsFormsApp1.Reportes.Forms
{
    public partial class RImventario : Form
    {
        public RImventario()
        {
            InitializeComponent();
        }

        private void RImventario_Load(object sender, System.EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'farmaciaDataSet2.Inventario' Puede moverla o quitarla según sea necesario.
            inventarioTableAdapter.Fill(farmaciaDataSet2.Inventario);

            reportViewer1.RefreshReport();
        }
    }
}
