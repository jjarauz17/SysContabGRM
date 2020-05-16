namespace Connectivity
{
    using Plugin.Connectivity;
    using System.Threading.Tasks;

    public class VerificarConexion
    {

        public async Task<Response> CheckConnection()
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                return new Response
                {
                    IsSuccess = false,
                    Mensaje = "Verificar configuración de Internet...",
                };
            }

            var isReachable = 
                await CrossConnectivity.Current.IsRemoteReachable("google.com");

            if (!isReachable)
            {
                return new Response
                {
                    IsSuccess = false,
                    Mensaje = "Verificar la Conexión a Internet...",
                };
            }

            return new Response
            {
                IsSuccess = true,
                Mensaje = "Ok",
            };

        }

    }

}
