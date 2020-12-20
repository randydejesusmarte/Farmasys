using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Reportes.Forms
{
    public partial class RFactura : Form
    {
        public RFactura()
        {
            InitializeComponent();
        }

        private void RFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'farmaciaDataSet.Factura' Puede moverla o quitarla según sea necesario.
            this.facturaTableAdapter.Fill(this.farmaciaDataSet.Factura);
            // TODO: esta línea de código carga datos en la tabla 'farmaciaDataSet.Factura' Puede moverla o quitarla según sea necesario.
            this.facturaTableAdapter.Fill(this.farmaciaDataSet.Factura);

            this.reportViewer1.RefreshReport();
        }
    }
}
