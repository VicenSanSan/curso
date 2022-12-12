using System;
using net1;
using MySql.Data.MySqlClient;

namespace net1
{
    class Program
    {
        static void Main(string[] args)
        {

            PersonaRepository repo=new PersonaRepository();
            MySqlConnection conn=repo.obtenerConexion();

            var comando = conn.CreateCommand();
            comando.CommandText = "select * from Personas";

            var reader = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString("nombre"));
            }
            Console.WriteLine("hola");
        }

    }
}

