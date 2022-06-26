using System;

//Luis Miguel Olarte Bello
//213022_9
//Ejercicio 1
//Código fuente: Autoría propia
namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creamos 2 nuevos objetos para cada clase
            CompaniaDeVuelo compania = new CompaniaDeVuelo();
            Pasajero pasajero = new Pasajero();

            //Damos la bienvenida al usuario
            Console.WriteLine("Bienvenido al programa para calcular el valor del tiquete de vuelo. \nPor favor ingrese los datos que se le solicitan a continuación... \n ");
            
            //Pedimos que ingrese el nombre del pasajero, este quedara guardado en el atributo nombre del objeto pasajero
            Console.WriteLine("Ingrese el nombre del pasajero: ");
            pasajero.setNombre(Console.ReadLine()); Console.WriteLine("\n");

            //Pedimos al usuario que ingrese la tarifa básica
            Console.WriteLine("Ingrese la tarifa básica: ");
            compania.setTarifaBasica(Convert.ToInt32(Console.ReadLine())); Console.WriteLine("\n");//Debemos convertir el tipo de datos a int ya que los datos ingresados por teclado son de tipo string
            
            //Pedimos al usuario que ingrese la edad, igualmente convertimos el tipo de dato a entero en el atributo edad
            Console.WriteLine("Ingrese la edad del pasajero: ");
            pasajero.setEdad(Convert.ToInt32(Console.ReadLine())); Console.WriteLine("\n");

            //Pedimos al usuario que nos indique si es o no temporada alta
            Console.WriteLine("Ingrese 'si' si es temporada alta, de lo contrario ingrese 'no': ");
            compania.setTemporada(Console.ReadLine()); Console.WriteLine("\n");

            //Pedimos al usuario que nos indique si es o no estudiante
            Console.WriteLine("Ingrese 'si' si es estudiante, de lo contrario ingrese 'no':");
            pasajero.setEsEstudiante(Console.ReadLine()); Console.WriteLine("\n");

            //Pedimos al usuario que nos ingrese la primer letra de la compañia
            Console.WriteLine("Ingrese 'a' para la compañía Alas o 'v' para la compañía Volar");
            compania.setAerolinea(Console.ReadLine());

            //hacemos un llamado al método que nos calcula el incremento en temporada alta para las dos aerolineas
            compania.incrementoTemporada();

            //Por medio del siguiente condicional verificamos la edad del pasajero y aplicamos el descuento del 50% en caso de que sea menor de edad
            

            //Por medio del siguiente condicnional verificamos si es mayor de edad y viaja en la compañia volar para hacer el recargo de $10.000
            if (pasajero.getEdad() > 60 && compania.getAerolinea() == "v")
            {
                compania.setTarifaBasica(compania.getTarifaBasica() + 10000);
            }

            //Por medio de la siguiente condicional verificamos si el pasajero es estudiante mayor de edad y si viaja en la compañía Alas para aplicarle el respectivo descuento del 10%
            if (pasajero.getEdad() >= 18 && pasajero.getEsEstudiante() == "si" && compania.getAerolinea() == "a")
            {
                compania.setTarifaBasica(compania.getTarifaBasica() - compania.getTarifaBasica() * 10 / 100);
            }

            //Imprimimos el resultado en pantalla
            Console.WriteLine("Para el pasajero " + pasajero.getNombre() + " El costo total del pasaje es de: " + compania.getTarifaBasica());

            Console.ReadKey();
        }
    }
}
