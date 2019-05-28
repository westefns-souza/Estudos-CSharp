using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Westefns.UI.Site.Models;

namespace Westefns.UI.Site.Data
{
    public class PedidoRepository : IPedidoRepository
    {
        public Pedido ObterPedido()
        {
            return new Pedido();
        }
    }

    public interface IPedidoRepository
    {
        Pedido ObterPedido();
    }
}
