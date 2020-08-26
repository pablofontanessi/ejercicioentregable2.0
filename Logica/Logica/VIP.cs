using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
   public class VIP: Cliente
    {
        public double MontoTC { get; set; }
        public double MontoFinanciado { get; set; }
        public override double ObtenerTasa()
        {
            double Tasa = base.ObtenerTasa();
            if ((MontoFinanciado - this.CalcularGastosFijos()) > 100000)
            {
                Tasa = Tasa - Tasa * 0.04;
            }

            return Tasa;
        }
        public override double CalcularMontoMaximoPrestamo()
        {
            return (base.CalcularMontoMaximoPrestamo() + MontoTC - MontoFinanciado) * 0.8;
        }
    }
}
