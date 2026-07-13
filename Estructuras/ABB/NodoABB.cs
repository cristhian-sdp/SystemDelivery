using SystemDelivery.Entidades;
using System;
using System.Text;
using System.Threading.Tasks;

namespace SystemDelivery.Estructuras.ABB
{
    internal class NodoABB
    {
        public Pedido Datos { get; set; }

        public NodoABB Izquierdo { get; set; }

        public NodoABB Derecho { get; set; }

        public NodoABB(Pedido pedido)
        {
            Datos = pedido;

            Izquierdo = null;

            Derecho = null;
        }
    }
}
