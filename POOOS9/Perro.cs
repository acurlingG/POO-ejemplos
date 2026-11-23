using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOOS9
{
    internal class Perro : Animal, Iacciones
    {
        public override void sonido()
        {
            Console.WriteLine("los perros hacen guagua");
        }

        public void moverse()
        {
            Console.WriteLine("Perro se mueve");
        }
       
        public void detenerse()
        {
            Console.WriteLine("Perro se detiene");
        }
    }
}


/**
 *
 * clase cajero1 : interfaz
 * 
 * interfaz : creditos, bonos vivienda
 *
 *
 *clase cajero2: interfaz2
 *
 *interfaz:  prestamos, cambiar dolares
 *
 *
 *clase cajero3 : interfaz3 : interfaz1 : intefaz3
 *
 *intefaz: plataforma
 *
 */