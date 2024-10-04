using Pet_Amigos.Classes.Models;
using Pet_Amigos.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Amigos.Controllers
{
    internal class ProviderController
    {
        private readonly ProviderService _providerService;

        public ProviderController()
        {
            _providerService = new ProviderService();
        }

        public void CrearTablaProveedor()
        {
            _providerService.CrearTabla();
        }

        public void AgregarProveedor(ProviderModel provider)
        {
            _providerService.InsertarProveedor(provider);
        }
    }
}
