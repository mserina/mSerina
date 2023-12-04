using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mSerina.Dtos
{
    /// <summary>
    /// Contiene los metodos y atributos de la clase Vajilla
    /// msm - 041223
    /// </summary>
    internal class Vajilla
    {
        //ATRIBUTOS

        public long idElemento = 0;
        public string codigoElemento = "aaaa";
        public string nombreElemento = "aaaaa";
        public string descripcionElemento = "aaaaa";
        public int cantidadElemento = 0;


        //GETTERS AND SETTERS
        public long IdElemento { get => idElemento; set => idElemento = value; }
        public string CodigoElemento { get => codigoElemento; set => codigoElemento = value; }
        public string NombreElemento { get => nombreElemento; set => nombreElemento = value; }
        public string DescripcionElemento { get => descripcionElemento; set => descripcionElemento = value; }
        public int CantidadElemento { get => cantidadElemento; set => cantidadElemento = value; }


        //CONSTRUCTORES

        public Vajilla(long idElemento,string nombreElemento, string descripcionElemento, int cantidadElemento)
        {
            this.idElemento = idElemento;
            this.nombreElemento = nombreElemento;
            this.descripcionElemento = descripcionElemento;
            this.cantidadElemento = cantidadElemento;
            this.codigoElemento = idElemento + nombreElemento;
        }

        public Vajilla() { 
        
        }

        //TO STRING
        override
        public string ToString()
        {
            string Vajilla =
            "codigoElemento: "+ this.codigoElemento +" Nombre: " + this.NombreElemento + " Cantidad: " + this.cantidadElemento;

            return Vajilla;
        }

    }
}
