using System.Data;
using Microsoft.Data.SqlClient;

public class AgendamentoSql : Database, IAgendamentoData
{
    public void Agendamento(Agendamento agendamento)
    {
    
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;
        cmd.CommandText = "INSERT INTO Agendamento Values(@data,@horario,@status)";

        cmd.Parameters.AddWithValue("@data", agendamento.Data);
        cmd.Parameters.AddWithValue("@horario", agendamento.Horario);
        cmd.Parameters.AddWithValue("@status", 0);

        cmd.ExecuteNonQuery();

    }

    //Orçamento

    // public List<Agendamento> Read()
    // {
    //     SqlCommand cmd = new SqlCommand();
    //     cmd.Connection = connection;
    //     cmd.CommandText = "SELECT * from Agendamento";
       

    //     SqlDataReader reader = cmd.ExecuteReader();

    //     List<Agendamento> lista = new List<Agendamento>();
    //     while (reader.Read())
    //     {
        
    //         Agendamento agendamento = new Agendamento();
    //         agendamento.Id = reader.GetInt32(0);
    //         agendamento.Data = reader.GetString(1);
    //         agendamento.Horario = reader.GetString(2);
    //         agendamento.Status = reader.GetInt32(3);
            
    //         lista.Add(agendamento);

    //     }

    //     return lista;

       
    // }



    

}