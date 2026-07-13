using SystemDelivery.Entidades;
using System;
using System.Text;
using System.Threading.Tasks;


namespace SystemDelivery.Estructuras.ListaDoble
{
    internal class NodoHistorial
    {
        public HistorialEstado Datos { get; set; }

        public NodoHistorial Anterior { get; set; }

        public NodoHistorial Siguiente { get; set; }

        public NodoHistorial(HistorialEstado historial)
        {
            Datos = historial;

            Anterior = null;

            Siguiente = null;
        }
    }
}
