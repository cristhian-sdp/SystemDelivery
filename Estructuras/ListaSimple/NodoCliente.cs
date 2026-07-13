using SystemDelivery.Entidades;
using System;
using System.Text;
using System.Threading.Tasks;

namespace SystemDelivery.Estructuras.ListaSimple
{
    internal class NodoCliente
    {
        public Cliente Datos { get; set; }

        public NodoCliente Siguiente { get; set; }

        public NodoCliente(Cliente cliente)
        {
            Datos = cliente;
            Siguiente = null;
        }
    }
}
