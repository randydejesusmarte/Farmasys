using System;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    internal class conectar
    {
        public SqlConnection SqlConnection = new SqlConnection();
        private readonly string cadena1 = $"Data source = DESKTOP-NDNKUPF\\SQLEXPRESS; Initial Catalog = farmacia; Integrated Security = True;";//laptop
        //private readonly string cadena1 = $"Data source = DESKTOP-LAVHCC6\\SQLEXPRESS01; Initial Catalog = farmacia; Integrated Security = True;";//pc

        public conectar()
        {
            SqlConnection.ConnectionString = cadena1;
        }

        public void Abrir()
        {
            try
            {
                SqlConnection.Open();
                Console.WriteLine("abierto");
            }
            catch (Exception es)
            {
                Console.WriteLine($"error{es}");
            }
        }
        public void Cerrar()
        {
            try
            {
                SqlConnection.Close();
            }
            catch (Exception es)
            {
                Console.WriteLine($"error{es}");
            }
        }
    }
}
