using System;
using System.Collections.Generic;
using System.Linq;

namespace Parcial2.Models
{
    public class Pedido : IEntidad
    {
        public const int MaximoPorItem = 20;

        public int Id { get; set; }
        public string Cliente { get; set; } = "";
        public string Telefono { get; set; } = "";       // se guarda solo con dígitos: 2235550101
        public string Observaciones { get; set; } = "";  // opcional: "sin suavizante", "mancha en la manga"
        public string Cuit { get; set; } = "";

        // Nombre de la forma de pago: "Efectivo", "Tarjeta", "Cuenta empresa".
        // En el JSON se guarda como TEXTO.
        public string FormaPago { get; set; } = "";
        public int Cuotas { get; set; } = 1;

        public List<ItemPedido> Items { get; set; } = new List<ItemPedido>();

        // Se congelan al confirmar el pedido. Ajuste negativo = descuento; positivo = recargo.
        public decimal Ajuste { get; set; }
        public decimal Total { get; set; }

        public EstadoPedido Estado { get; set; } = EstadoPedido.EnEspera;
        public DateTime FechaIngreso { get; set; } = DateTime.Now;

        // TODO 2 · Modelo y validaciones. Reglas completas en el README. Resumen:
        //  - AgregarItem: solo si el pedido está EnEspera (si no, InvalidOperationException);
        //    prenda obligatoria; cantidad entre 1 y MaximoPorItem; si la prenda ya está, se SUMA la cantidad.
        //  - CalcularSubtotal: suma de los subtotales de los ítems.
        //  - AvanzarEstado: EnEspera -> Lavando -> ParaRetirar -> Entregado. Un pedido finalizado no avanza.
        //  - Cancelar: solo si está EnEspera o Lavando.
        // Dato inválido: ArgumentException. Operación que no corresponde: InvalidOperationException.

        public void AgregarItem(Prenda prenda, int cantidad)
        {
            throw new NotImplementedException("Falta el TODO 2: Pedido.AgregarItem");
        }

        public decimal CalcularSubtotal()
        {
            throw new NotImplementedException("Falta el TODO 2: Pedido.CalcularSubtotal");
        }

        public bool EstaFinalizado()
        {
            return Estado == EstadoPedido.Entregado || Estado == EstadoPedido.Cancelado;
        }

        public void AvanzarEstado()
        {
            throw new NotImplementedException("Falta el TODO 2: Pedido.AvanzarEstado");
        }

        public void Cancelar()
        {
            throw new NotImplementedException("Falta el TODO 2: Pedido.Cancelar");
        }
    }
}
