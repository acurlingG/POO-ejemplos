using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOOS9
{
    internal class Program
    {
        /*  Herencia, polimorfismo, interfaces, constructores, get y set  */
        static void Main(string[] args)
        {

            var Persona1 = new Persona("123","Claudia Jiron","12345678"); // instancia
            var Persona2 = new Persona("456","Sofia Ramirez","88888888"); // instancia

            var Persona3 = new Persona();
            Persona3.cedula = "789";
            Persona3.nombre = "Ricardo Noguera";
            Persona3.telefono = "83921091";
            

            var Persona4 = new Persona("123");  

            Empleado empleado1 = new Empleado(150);
            //empleado1.cedula = "741";
            //empleado1.nombre = "Esteban Chamorro";
            //empleado1.telefono = "78458796";



            Persona.direccion ="Francia";


            Console.WriteLine($"Cedula: {Persona1.cedula} Nombre:{Persona1.nombre} Telefono: {Persona1.telefono} Pais: {Persona.direccion}");
            Console.WriteLine($"Cedula: {Persona2.cedula} Nombre:{Persona2.nombre} Telefono: {Persona2.telefono} Pais: {Persona.direccion}");
            Console.WriteLine($"Cedula: {Persona3.cedula} Nombre:{Persona3.nombre} Telefono: {Persona3.telefono} Pais: {Persona.direccion}");
            Console.WriteLine($"Cedula: {empleado1.cedula} Nombre:{empleado1.nombre} Telefono: {empleado1.telefono} Salario: {empleado1.salario}");
            Console.WriteLine($"Cedula: {Persona4.cedula} ");

         //   empleado1.AgregarEmpleado();


            Animal animales = new Animal();
            Animal perro = new Perro();
            Animal  gato = new Gato ();

            animales.sonido();
            perro.sonido();
            gato.sonido();


            

            Console.ReadLine();


        }
    }
}
