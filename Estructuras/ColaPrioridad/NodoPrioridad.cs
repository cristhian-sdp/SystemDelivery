using SystemDelivery.Entidades;
using System;
using System.Text;
using System.Threading.Tasks;

namespace SystemDelivery.Estructuras.ColaPrioridad
{
    internal class NodoPrioridad
    {
        public Pedido Datos { get; set; }

        public NodoPrioridad Siguiente { get; set; }

        public NodoPrioridad(Pedido pedido)
        {
            Datos = pedido;
            Siguiente = null;
        }
    }
}
