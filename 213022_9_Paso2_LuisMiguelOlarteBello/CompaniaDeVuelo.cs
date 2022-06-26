using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class CompaniaDeVuelo:Pasajero 
    {
        int tarifaBasica;
        string temporada;
        string aerolinea;
        
        

        public int setTarifaBasica (int tarifaBasica)
        {
            this.tarifaBasica = tarifaBasica;
            return tarifaBasica;
        }

        public int getTarifaBasica()
        {
            return tarifaBasica;
        }

        public string setTemporada(string temporada)
        {
            this.temporada = temporada;
            return temporada;
        }

        public string getTemporada()
        {
            return temporada;
        }

        public string setAerolinea(string aerolinea)
        {
            this.aerolinea = aerolinea;
            return aerolinea;
        }

        public string getAerolinea()
        {
            return aerolinea;
        }

        public int incrementoTemporada()
            {
                if (aerolinea == "a" && temporada == "si")
                {
                    tarifaBasica += tarifaBasica * 30 / 100;
                }
                else if (aerolinea == "v" && temporada == "si")
                {
                    tarifaBasica += tarifaBasica * 20 / 100;
                }
                return tarifaBasica;
            }


        public int calcularTarifa()
        {
            int tarifaCalculada = 0;

                if(getEdad() < 18)
                {
                    tarifaCalculada = tarifaBasica - tarifaBasica * 50 / 100; 
                } else if (getEdad() > 60)
                {
                tarifaCalculada = tarifaBasica + 10000;  
                }else
            {
                tarifaCalculada = tarifaBasica;
            }

            return tarifaCalculada;
        }

        
       
        
           

    }
}
