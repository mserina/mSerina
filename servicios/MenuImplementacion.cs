using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mSerina.servicios
{
    /// <summary>
    /// Es una clase que contiene la logica de los metodos 
    /// msm - 041223
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenu()
        {
            int opcionSeleccionada;

            Console.WriteLine("#############");
            Console.WriteLine("0[] Cerrar Menu");
            Console.WriteLine("1[] Dar Alta");
            Console.WriteLine("2[] Dar Baja");
            Console.WriteLine("#############");

            opcionSeleccionada = Console.ReadKey(true).KeyChar - ('0');

            return opcionSeleccionada;

        }
    }
}
