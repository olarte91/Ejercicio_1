using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_1
{
    public class Pasajero
    {
        private string nombre;
        private int edad;
        private string esEstudiante;

        public string setNombre(string nombre)
        {
            this.nombre = nombre;
            return nombre;
        }

        public string getNombre()
        {
            return nombre;
        }

        public int setEdad(int edad)
        {
            this.edad = edad;
            return edad;
        }

        public int getEdad()
        {
            return edad;
        }

        public string setEsEstudiante (string esEstudiante)
        {
            this.esEstudiante = esEstudiante;
            return esEstudiante;
        }

        public string getEsEstudiante()
        {
            return esEstudiante;
        }
    }
}
