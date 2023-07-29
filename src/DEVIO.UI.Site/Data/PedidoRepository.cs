using DEVIO.UI.Site.Models;
using static DEVIO.UI.Site.Data.PedidoRepository;

namespace DEVIO.UI.Site.Data
{
    public class PedidoRepository : IPedidoRepository
    {
        public Pedido ObterPedido()
        {
            return new Pedido();
        }

        public interface IPedidoRepository
        {
            Pedido ObterPedido();
        }
    }
}
