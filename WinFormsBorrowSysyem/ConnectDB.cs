
using Npgsql;
using System.Data;



namespace WinFormsBorrowSystem
{
    internal class ConnectDB
    {

        private string connectionString = "Host=localhost;Username=admin;Password=admin;Database=BorrowSystem";

        public NpgsqlConnection conn;
        public ConnectDB()
        {
            conn = new NpgsqlConnection(connectionString);
        }

        public DataTable Query(NpgsqlCommand cmd)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataTable dTable = new DataTable();
                DataSet dSet = new DataSet();

                adapter.Fill(dSet, "dataTable");
                dTable = dSet.Tables["dataTable"];

                conn.Close();
                return dTable;
            }
            catch (Exception ex)
            {

                conn.Close();
            }
            return new DataTable();
        }

        public bool Execute(NpgsqlCommand cmd)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                int rowAffected = cmd.ExecuteNonQuery();
                conn.Close();
                return true;
                
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
                
            }
        }
    }
}
