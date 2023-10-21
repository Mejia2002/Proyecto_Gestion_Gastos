using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GastoOtrosInsumo
    {
        public string NombreProducto;

        public decimal CostoProducto;

        public DateTime FechaCompra { get; set; }

        public GastoOtrosInsumo()
        {
        }

        public GastoOtrosInsumo(string nombreProducto, decimal costoProducto, DateTime fechaCompra)
        {
            NombreProducto = nombreProducto;
            CostoProducto = costoProducto;
            FechaCompra = fechaCompra;
        }

        public override string ToString()
        {
            return $"{FechaCompra};{NombreProducto};{CostoProducto}";
        }

    }
}
