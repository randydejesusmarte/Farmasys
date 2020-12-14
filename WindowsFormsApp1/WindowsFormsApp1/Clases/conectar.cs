using System;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    internal class conectar
    {
        public SqlConnection SqlConnection = new SqlConnection();
        private readonly string cadena1 = "Data source = DESKTOP-NDNKUPF\\SQLEXPRESS; Initial Catalog = farmacia; Integrated Security = True;";

        public conectar()
        {
            SqlConnection.ConnectionString = cadena1;
        }

        public void Abrir()
        {
            try
            {
                SqlConnection.Open();
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
