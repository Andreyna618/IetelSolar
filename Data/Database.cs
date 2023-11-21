using Microsoft.Data.SqlClient;

public abstract class Database : IDisposable
{
    protected SqlConnection connection;

    public Database()
    {
        //connection = new SqlConnection("Data Source=DESKTOP-LAB0517\\SQLSERVER2019; Initial Catalog=IETELSolar; Integrated Security=SSPI; TrustServerCertificate=true;");
        connection = new SqlConnection("Data Source=ANDREYNA_RILDO\\SQLEXPRESS; Initial Catalog=IETELSolar; Integrated Security=True; TrustServerCertificate=true;");
        connection.Open();
    }

    public void Dispose()
    {
        connection.Close();
    }
    
}
