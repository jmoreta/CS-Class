using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class Persona1
    {
        public string nombre;
        public string apellidos;
        public string direccion;
        protected string ciudad;
        internal int edad;

        public Persona1()
        {
            nombre = "Jose Moreta";
            apellidos = "Moreta Jaquez";
            direccion = "12 de julio";
            ciudad = "puerto plata";
            edad = 25;
        }
        
        public Persona1 (string Nombre,String Apellido,Int16 Edad)
        {
            nombre = Nombre;
            apellidos = Apellido;
            edad =Edad;
            
        }

        //encasuplacion 
        public string CiudadPerdida()
        {
            return ciudad;
        }


    }
}
