using System.Windows.Forms;

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
            // TODO: esta línea de código carga datos en la tabla 'farmaciaDataSet1.Inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.farmaciaDataSet1.Inventario);
            // TODO: esta línea de código carga datos en la tabla 'farmaciaDataSet1.Inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.farmaciaDataSet1.Inventario);

            this.reportViewer1.RefreshReport();
        }
    }
}
