
using Npgsql;



namespace WinFormsBorrowSystem
{
    internal class ConnectDB
    {

        string ConnectionString = "host = localhost; port=5432; database=BorrowSystem;User=root; password=admin;";

        public void Connect()
        {
            using (var conn = new NpgsqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Connection Success!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An Error occured: {ex.Message}");

                }

            }

        }
    }
}
