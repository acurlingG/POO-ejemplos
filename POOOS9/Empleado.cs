using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOOS9
{
    internal class Empleado : Persona 
    {
        public float salario { get; set; }

        public Empleado(float Salario)
        {
            salario = Salario;
        }

        public void AgregarEmpleado() {

            Console.WriteLine("ingrese el nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese Cedula: ");
            cedula = Console.ReadLine();
            
            Console.WriteLine($"Nombre: {nombre} Cedula: {cedula} Salario: {salario}"); 
        
        }
    }
}
