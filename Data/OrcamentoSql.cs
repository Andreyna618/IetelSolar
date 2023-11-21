using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;
using Microsoft.Data.SqlClient;
public class OrcamentoSql : Database, IOrcamentoData
{  

    public List<Agendamento> Read()
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;
        cmd.CommandText = "SELECT * from Agendamento";
       

        SqlDataReader reader = cmd.ExecuteReader();

        List<Agendamento> lista = new List<Agendamento>();
        while (reader.Read())
        {       
            Agendamento agendamento = new Agendamento();
            agendamento.Id = reader.GetInt32(0);
            agendamento.Data = reader.GetString(1);
            agendamento.Horario = reader.GetString(2);
            agendamento.Status = reader.GetInt32(3);
            
            lista.Add(agendamento);
        }

        return lista;
       
    }



    // public List<Orcamento> Read()
    // {
    //     SqlCommand cmd = new SqlCommand();
    //     cmd.Connection = connection;
    //     cmd.CommandText = "SELECT * from Agendamento";


    //     SqlDataReader reader = cmd.ExecuteReader();

    //     List<Orcamento> lista = new List<Orcamento>();
    //     while(reader.Read())
    //     {
    //         Orcamento agendamento = new Orcamento();
    //         agendamento.Id= reader.GetInt32(0);
    //         agendamento.Nome = reader.GetString(1);
    //         agendamento.CPF = reader.GetString(2);
    //         agendamento.Telefone = reader.GetString(3);
    //         agendamento.Endereco = reader.GetString(4);
    //         agendamento.Bairro = reader.GetString(5);
    //         agendamento.Numero = reader.GetString(6);
    //         agendamento.CEP = reader.GetString(7);
    //         agendamento.Cidade = reader.GetString(8);
    //         agendamento.Data = reader.GetString(9);
    //         agendamento.Horario = reader.GetString(10);
    //         agendamento.Agendamento = new Agendamento{Id=reader.GetInt32(11), Data= reader.GetString(12), Horario = reader.GetString(13), Status = reader.GetInt32(14)};

    //         lista.Add(agendamento);

    //     }

    // return lista;
    
    


}
