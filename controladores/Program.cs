using mSerina.servicios;
using mSerina.Dtos;

namespace mSerina
{
    /// <summary>
    /// clase principal del programa 
    /// msm - 041223
    /// </summary>
    public class program
    {
        /// <summary>
        /// Metodo que contiene el procedimiento del programa 
        /// msm - 041223
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
           List<Vajilla> listaVajilla = new List<Vajilla>();

            //Objetos
            MenuInterfaz mi = new MenuImplementacion();
            OperacionInterfaz op = new OperacionImplementacion();

            //Variable
            bool cerrarMenu = false;
            int opcionSeleccionada;

            while (!cerrarMenu)
            {
                opcionSeleccionada = mi.mostrarMenu();

                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("Cerrando Menu");
                        cerrarMenu |= true;
                        break;
                    case 1:
                        Console.WriteLine("Abriendo opcion 1");
                        op.darAlta(listaVajilla);   
                        foreach (Vajilla elementos in listaVajilla)
                        {
                            Console.WriteLine(elementos.ToString());
                        }
                        break;
                    case 2:
                        Console.WriteLine("Abriendo opcion 2");
                        op.darBaja(listaVajilla);
                        foreach (Vajilla elementos in listaVajilla)
                        {
                            Console.WriteLine(elementos.ToString());
                        }
                        break;
                    case 3:
                        Console.WriteLine("Abriendo opcion 3");
                        break;
                    default:
                        Console.WriteLine("Esa opcion no existe");
                        break;
                }
            }

        }
    }
}