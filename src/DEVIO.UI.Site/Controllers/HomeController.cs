using DEVIO.UI.Site.Data;
using DEVIO.UI.Site.Servicos;
using Microsoft.AspNetCore.Mvc;
using System.Security;
using static DEVIO.UI.Site.Data.PedidoRepository;

namespace DEVIO.UI.Site.Controllers
{
    public class HomeController : Controller
    {
        public OperacaoService OperacaoService { get; }

        public OperacaoService OperacaoService2 { get; }

        public HomeController(OperacaoService operacaoService, OperacaoService operacaoService2)
        {
            OperacaoService = operacaoService;
            OperacaoService = operacaoService2;
        }

        public string Index()
        {
            return
                "Primeira instancia: " + Environment.NewLine +
                OperacaoService.Transient.OperacaoId + Environment.NewLine +
                OperacaoService.Scoped.OperacaoId + Environment.NewLine +
                OperacaoService.Singleton.OperacaoId + Environment.NewLine +
                OperacaoService.SingletonInstance.OperacaoId + Environment.NewLine;/* +

                Environment.NewLine +
                Environment.NewLine +

                "Segunda instancia: " + Environment.NewLine +
                OperacaoService2.Transient.OperacaoId + Environment.NewLine +
                OperacaoService2.Scoped.OperacaoId + Environment.NewLine +
                OperacaoService2.Singleton.OperacaoId + Environment.NewLine +
                OperacaoService2.SingletonInstance.OperacaoId + Environment.NewLine;
            */
            
        }

        /*
        private readonly IPedidoRepository _pedidoRepository;

        public HomeController(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
        */
        /*
        public IActionResult Index([FromServices] IPedidoRepository _pedidoRepository)
        {
            var pedido = _pedidoRepository.ObterPedido();

            return View();
        }
        */
    }
}
