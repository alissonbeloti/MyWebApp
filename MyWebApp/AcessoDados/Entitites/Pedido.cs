using System;
using System.Collections.Generic;

namespace MyWebApp.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public ICollection<ItemPedido> ItensPedido { get; set; }
    }
}
