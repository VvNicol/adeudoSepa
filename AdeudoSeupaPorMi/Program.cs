using AdeudoSeupaPorMi.Dto;
using AdeudoSeupaPorMi.Servicios;

namespace AdeudoSeupaPorMi
{

    internal class Program
    {
        //Poner statico todas las listas y rutas que se usaran para los archivos log
        static List<ClienteDto> listaCliente = new List<ClienteDto>();
        //la direccion tiene que terminar con 2 barras
        static string rutaBibilioteca = "D:\\VisualStudioProyectos\\Proyectos\\AdeudoSeupaPorMi\\ArchivoBiblioteca\\";
        static void Main(string[] args)
        {
            OperativaInterfaz oi = new OperativaImplementacion();

            string entrada;
            //con el do while se recogen todos los clientes 
            do
            {
                //Aqui iria nuestro menu con opciones 
                oi.AltaCliente(listaCliente);

                // Deberia estar dentro del metodo y que lo guarde cuando se necesite
                Console.WriteLine("Guardar cambios?? (s/n)");
                entrada = Console.ReadLine();

            } while (entrada.Equals('s'));
            //Genera los ficheros automaticamente
            
            foreach (ClienteDto cliente in listaCliente)
            {
               //  Es solo para que cuando se cree el fichero se ponga el nombre automaticamente
                string[] nombreDesagregado = cliente.NombreDeudor.Split(" ");
                string nombreFichero = nombreDesagregado[0] + nombreDesagregado[1] + ".txt";
                string rutaCompletaFichero = rutaBibilioteca + nombreFichero;

                using (StreamWriter ficheroBiblioteca = new StreamWriter(rutaCompletaFichero))
                {
                    ficheroBiblioteca.WriteLine(oi.CrearContenido(cliente));
                    //aqui se pone el metodo en el cual esta la forma ya prederteminada ed como se guardara
                }

            }
        }
    }
}
