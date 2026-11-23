using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOOS9
{
    internal class Persona
    {
        // Atributos de una persona
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public static string direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }

        // constructor
        public Persona(string Cedula, string Nombre, String Telefono)
        { 
            cedula = Cedula;
            nombre = Nombre;
            telefono = Telefono;
        }

        public Persona(string Cedula)
        {
            cedula = Cedula;
        }
        public Persona() { }


        public void Agregar() { Console.WriteLine("Agregar persona"); }
        public void Borrar() { Console.WriteLine("Borrar persona"); }
    }
}
