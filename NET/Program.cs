using System;
using net1;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace net1
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonaRepository repo = new PersonaRepository();
            List<PersonaNueva> lista = repo.BuscarTodas();
            foreach (var persona in lista)
            {
                Console.Write(persona.Dni);
                Console.Write(persona.Nombre);
                Console.WriteLine(persona.Apellidos);
            }

            List<PersonaNueva> listaordenada = repo.BuscarTodasOrdenadas();
            foreach (var persona in listaordenada)
            {
                Console.Write(persona.Apellidos);
                Console.Write(persona.Nombre);
                Console.WriteLine(persona.Dni);
                
            }
            Console.WriteLine("hola");

            PersonaNueva pnueva=new PersonaNueva("101","angelito","perez");
            repo.Insertar(pnueva);

            List<PersonaNueva> lista2 = repo.BuscarTodasOrdenadas();
            foreach (var persona in lista2)
            {
                Console.Write(persona.Apellidos);
                Console.Write(persona.Nombre);
                Console.WriteLine(persona.Dni);
            }
            
            PersonaNueva pBorrar =new PersonaNueva("101","angelito","perez");
            repo.BorrarPersona(pBorrar);
                    


        }

    }
}

