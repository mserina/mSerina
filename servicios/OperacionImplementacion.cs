using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mSerina.Dtos;

namespace mSerina.servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {
              
        private Vajilla crearElemento()
        {
            long idElemento;
            string nombreElemento;
            string descripcionElemento;
            int cantidadElemento;
            string codigoElemento;

            Console.WriteLine("Inserte un id (long)");
            idElemento = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Inserte nombre del elemento");
            nombreElemento = Console.ReadLine();
            Console.WriteLine("Inserte descripcion del elemento");
            descripcionElemento = Console.ReadLine();
            Console.WriteLine("Inserte cantidad del elemento");
            cantidadElemento = Convert.ToInt32(Console.ReadLine());

            Vajilla elementoNuevo = new Vajilla(idElemento, nombreElemento, descripcionElemento, cantidadElemento);

            return elementoNuevo;
        }

        public void darAlta(List<Vajilla> listaAntigua)
        {
            listaAntigua.Add(crearElemento());
        }

        public void darBaja (List<Vajilla> listaAntigua)
        {
            int cantidad;
            int resultado;
            Console.WriteLine("Inserte codigoElemento");
            string codigoElementoInsertado = Console.ReadLine();

            foreach(Vajilla vajilla in listaAntigua)
            {
                if (codigoElementoInsertado.Equals(vajilla.CodigoElemento))
                {
                    Console.WriteLine("Inserte cantidad a borrar del elemento");
                    cantidad = Convert.ToInt32(Console.ReadLine());
                    vajilla.CantidadElemento = cantidad - vajilla.cantidadElemento;
                }    
            }
        }
    }
}
