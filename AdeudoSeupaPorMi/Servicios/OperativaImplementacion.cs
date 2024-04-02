using AdeudoSeupaPorMi.Dto;

namespace AdeudoSeupaPorMi.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void AltaCliente(List<ClienteDto> listaCliente)
        {
            ClienteDto cliente = new ClienteDto();

            Console.WriteLine("Nombre deudor: ");
            cliente.NombreDeudor = Console.ReadLine();
            Console.WriteLine("Dirección deudor: ");
            cliente.DireccionDeudor = Console.ReadLine();
            Console.WriteLine("CP deudor: ");
            cliente.CpDeudor = Console.ReadLine();
            Console.WriteLine("IBAN deudor: ");
            cliente.IbanDeudor = Console.ReadLine();
            Console.WriteLine("Swift deudor: ");
            cliente.SwiftBancoDeudor = Console.ReadLine();
            Console.WriteLine("Tipo pago: ");
            cliente.TipoPagoDeudor = Convert.ToChar(Console.ReadLine());

            cliente.ReferenciaOrden = siguienteReferencia(listaCliente);

            listaCliente.Add(cliente);
        }

        //creandoun id pero este va en utilidades
        private long siguienteReferencia(List<ClienteDto> listaCliente)
        {
            int tamanioLista = listaCliente.Count;
            long nuevaReferencia;
            if (tamanioLista > 0)
            {
                nuevaReferencia = listaCliente[tamanioLista - 1].ReferenciaOrden + 1;
            }
            else
            {
                nuevaReferencia = 1;
            }

            return nuevaReferencia;
        }

        public string CrearContenido(ClienteDto cliente)
        {
            //aqui se puede referenciar otro dato como por ejemplo la empresa 
            string contenido = "Nombre\n" +
                $"DATO: {cliente.NombreDeudor}";
            return contenido;
        }
    }
}