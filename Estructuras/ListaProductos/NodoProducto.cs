using SystemDelivery.Entidades;
using System;
using System.Text;
using System.Threading.Tasks;

namespace SystemDelivery.Estructuras.ListaProductos
{
    internal class NodoProducto
    {
        public Producto Datos { get; set; }

        public NodoProducto Siguiente { get; set; }

        public NodoProducto(Producto producto)
        {
            Datos = producto;
            Siguiente = null;
        }
    }
}
