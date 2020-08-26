using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
   public class Riesgoso: Cliente
    {
        public int CantidadPrestamosSinPagar { get; set; }
        public double MontoDeuda { get; set; }

        public override double ObtenerTasa()
        {
            double Tasa = base.ObtenerTasa();
            if ( MontoDeuda > 50000)
            {
                Tasa = Tasa + Tasa * 0.05;
            }

            return Tasa;
        }
        public override double CalcularMontoMaximoPrestamo()
        {
            return base.CalcularMontoMaximoPrestamo()* 0.7;
        }
    }
    
}
