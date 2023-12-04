using mSerina.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mSerina.servicios
{
    internal interface OperacionInterfaz
    {
        /// <summary>
        /// Metodo que da de alta un elemento
        /// msm - 041223
        /// </summary>
        /// <param name="listaAntigua">Lista de tipo Vajilla donde se guardara los nuevos elementos</param>
        public void darAlta(List<Vajilla> listaAntigua);

        /// <summary>
        /// Metodo que borra cantidad de un elemento en base a la cantidad que se especifique
        /// </summary>
        /// <param name="listaAntigua">Lista de tipo Vajilla donde se guardara los nuevos elementos</param>
        public void darBaja(List<Vajilla> listaAntigua);


    }
}
