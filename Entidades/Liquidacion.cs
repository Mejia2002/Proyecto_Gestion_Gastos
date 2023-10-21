using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Liquidacion
    {
        public string IdentificacionL { get; set; }

        public int MesL { get; set; }

        public int AñoL { get; set; }

        public int DiasTrabajados { get; set; }

        public decimal LiquidacionPorDia { get; set; }

        public decimal TotalLiquidacion { get; set; }

        public Liquidacion()
        {
        }

        public Liquidacion(string identificacionL, int mesL, int añoL, int diasTrabajados, decimal liquidacionPorDia, decimal totalLiquidacion)
        {
            IdentificacionL = identificacionL;
            MesL = mesL;
            AñoL = añoL;
            DiasTrabajados = diasTrabajados;
            LiquidacionPorDia = liquidacionPorDia;
            TotalLiquidacion = totalLiquidacion;
        }

        public override string ToString()
        {
            return $"{IdentificacionL};{MesL};{AñoL};{DiasTrabajados};{LiquidacionPorDia};{TotalLiquidacion}";
        }

    }



}
