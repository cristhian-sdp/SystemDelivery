using SystemDelivery.Entidades;
using System;
using System.Text;
using System.Threading.Tasks;

namespace SystemDelivery.Estructuras.ListaCircular
{
    internal class NodoRepartidor
    {
        public Repartidor Datos { get; set; }

        public NodoRepartidor Siguiente { get; set; }

        public NodoRepartidor(Repartidor repartidor)
        {
            Datos = repartidor;
            Siguiente = null;
        }
    }
}
