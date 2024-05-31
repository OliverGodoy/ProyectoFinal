using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Data.Clases
{
    internal class Final
    {
        public int anio {  get; set; }
        public string finalista1 { get; set; }
        public string finalista2 { get; set;}
        public string campeon {  get; set; }
        public string resultado { get; set; }
        public DateTime fecha { get; set; }
        public string cede { get; set; }
        public string goleador { get; set; }
        public int cantidad { get; set; }

        //Constructor
        public Final() { }

        //Constructor con parametros
        public Final(int Anio,string Finalista1,string Finalista2,string Campeon,string Resultado,DateTime Fecha,string Cede,string Goleador,int Cantidad)
        {
            anio = Anio;
            finalista1 = Finalista1;
            finalista2 = Finalista2;
            campeon = Campeon;
            resultado = Resultado;
            fecha = Fecha;
            cede = Cede;
            goleador = Goleador;
            cantidad = Cantidad;
        }

    }
}
