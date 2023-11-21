using Microsoft.Data.SqlClient;

public class VagasSql: Database, IVagasData
{
    public void AdicionaVaga(Vagas vagas)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;
        cmd.CommandText = "INSERT INTO Vagas Values(@cargo,@modelo,@tipo,@local,@descricao)";

        cmd.Parameters.AddWithValue("@cargo",vagas.cargo);
        cmd.Parameters.AddWithValue("@modelo",vagas.modelo);
        cmd.Parameters.AddWithValue("@tipo",vagas.tipo);
        cmd.Parameters.AddWithValue("@local",vagas.local);
        cmd.Parameters.AddWithValue("@descricao",vagas.descricao);

        cmd.ExecuteNonQuery();
    }
}