using System;
using System.Collections.Generic;

namespace Parcial2.Pagos
{
    // TODO 5 · Factory
    // La forma de pago se elige EN EJECUCIÓN y llega como TEXTO (del ComboBox o del JSON).
    // Este es el ÚNICO lugar del sistema que conoce las clases concretas de pago.
    public static class PagoFactory
    {
        public static IPagoStrategy Crear(string tipo)
        {
            // Recibe el texto ("Tarjeta") y devuelve la estrategia correcta.
            // Si el texto no corresponde a ninguna, ArgumentException con un mensaje claro.
            throw new NotImplementedException("Falta el TODO 5: PagoFactory.Crear");
        }

        // La usa el ComboBox: la vista no escribe nombres a mano.
        public static List<string> TiposDisponibles()
        {
            return new List<string> { "Efectivo", "Tarjeta", "Cuenta empresa" };
        }
    }
}
