using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mSerina.servicios
{
    /// <summary>
    /// Interfaz,contiene la cabezera de los metodos
    /// msm - 041223
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el menu y guarda la respuesta del usuario
        /// msm - 041223
        /// </summary>
        /// <returns>Devuelve la respuesta del usuario</returns>
        public int mostrarMenu();
    }
}
