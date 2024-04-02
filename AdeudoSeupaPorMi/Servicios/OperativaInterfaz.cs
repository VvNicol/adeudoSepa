using AdeudoSeupaPorMi.Dto;

namespace AdeudoSeupaPorMi.Servicios
{
    internal interface OperativaInterfaz
    {
        void AltaCliente(List<ClienteDto> listaCliente);
        string CrearContenido(ClienteDto cliente);
    }
}