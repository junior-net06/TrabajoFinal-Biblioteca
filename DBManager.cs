using System;
using System.Data;
using System.Data.OleDb;

public class DBManager
{
    private string connectionString;

    public DBManager()
    {
        // Cambia la cadena de conexión según tu ruta
        connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Database\BibliotecaDB.accdb;Persist Security Info=False;";
    }

    // Método para ejecutar consultas SELECT
    public DataTable ExecuteQuery(string query)
    {
        using (OleDbConnection connection = new OleDbConnection(connectionString))
        {
            connection.Open();
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            connection.Close();
        }
    }

    // Método para ejecutar consultas INSERT, UPDATE, DELETE
    public int ExecuteNonQuery(string query)
    {
        using (OleDbConnection connection = new OleDbConnection(connectionString))
        {
            connection.Open();
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                return command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }
}
