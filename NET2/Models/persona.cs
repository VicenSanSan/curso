using System;
using System.Collections.Generic;

namespace net2.Models{
    public class Persona{
        public string Dni{get;set;}
        public string Nombre {get;set;}
        public string Apellidos {get;set;}

        public Persona(string dni,string nombre, string apellidos){
            Dni=dni;
            Nombre=nombre;
            Apellidos=apellidos; 
        }
    }
}