using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
   public class Normal: Cliente
    {
        public double MontoAhorro { get; set; }
        public override double CalcularMontoMaximoPrestamo()
        {
            return (base.CalcularMontoMaximoPrestamo() + MontoAhorro) *0.75;
        }
    }
}
