using System.Collections.Generic;
using net1;
using MySql.Data.MySqlClient;

public class PersonaRepository
{
    public List<PersonaNueva> BuscarTodas()
    {
        var sb = new MySqlConnectionStringBuilder
        {
            Server = "localhost",
            UserID = "root",
            Password = "",
            Port = 3306,
            Database = "curso2"
        };
        MySqlConnection conn = new MySqlConnection(sb.ConnectionString);
        conn.Open();

        var comando = conn.CreateCommand();
        comando.CommandText = "select * from Personas";

        var reader = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        List<PersonaNueva> lista = new List<PersonaNueva>();
        while (reader.Read())
        {
            PersonaNueva p = new PersonaNueva(reader.GetString("dni"),
            reader.GetString("nombre"),
            reader.GetString("apellidos"));
            lista.Add(p);
        }
        return lista;
    }

    public List<PersonaNueva> BuscarTodasOrdenadas()
    {
        var sb = new MySqlConnectionStringBuilder
        {
            Server = "localhost",
            UserID = "root",
            Password = "",
            Port = 3306,
            Database = "curso2"
        };
        MySqlConnection conn = new MySqlConnection(sb.ConnectionString);
        conn.Open();

        var comando = conn.CreateCommand();
        comando.CommandText = "select * from Personas order by apellidos";

        var reader = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        List<PersonaNueva> lista = new List<PersonaNueva>();
        while (reader.Read())

        {
            PersonaNueva p = new PersonaNueva(reader.GetString("dni"),
            reader.GetString("nombre"),
            reader.GetString("apellidos"));
            lista.Add(p);

        }
        return lista;


    }




     public void Insertar (PersonaNueva persona)
    {
        var sb = new MySqlConnectionStringBuilder
        {
            Server = "localhost",
            UserID = "root",
            Password = "",
            Port = 3306,
            Database = "curso2"
        };
        MySqlConnection conn = new MySqlConnection(sb.ConnectionString);
        conn.Open();

        var comando = conn.CreateCommand();
        comando.CommandText = "insert into Personas values ('"+ persona.Dni + "','" + persona.Nombre +"','" + persona.Apellidos+ "')";
        comando.ExecuteNonQuery();
        
    }
    public void BorrarPersona (PersonaNueva persona)
    {
        var sb = new MySqlConnectionStringBuilder
        {
            Server = "localhost",
            UserID = "root",
            Password = "",
            Port = 3306,
            Database = "curso2"
        };
        MySqlConnection conn = new MySqlConnection(sb.ConnectionString);
        conn.Open();

        var comando = conn.CreateCommand();
        comando.CommandText = "delete from Personas where nombre = '"+ persona.Nombre + "')";
        comando.ExecuteNonQuery();
        
    }
    public void Ver (PersonaNueva persona)
    {
        var sb = new MySqlConnectionStringBuilder
        {
            Server = "localhost",
            UserID = "root",
            Password = "",
            Port = 3306,
            Database = "curso2"
        };
        MySqlConnection conn = new MySqlConnection(sb.ConnectionString);
        conn.Open();

        var comando = conn.CreateCommand();
        comando.CommandText = "select from Personas where dni=  ('"+ persona.Dni + "'";
        comando.ExecuteNonQuery();
        
    }



}



