using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  Persona1 persona1 = new Persona1();

            Console.WriteLine(persona1.nombre);
            Console.WriteLine(persona1.CiudadPerdida()); 

            Console.ReadKey(); */



            bool boo = false;

            for (int x = 0; x <= 10; x++)
            {
                if (boo)
                {
                    Console.WriteLine("El valor de boo es TRUE");
                    
                }

                else
                {
                    Console.WriteLine("El Valor de boo es False");
                        
                }

                if (boo)
                    boo = false;
                else boo = true;



            }

            Console.ReadKey();



        }



    }
}
