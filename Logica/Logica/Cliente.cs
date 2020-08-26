using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
   public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Cuit { get; set; }
        public DateTime FechaNac { get; set; }
        public Double SueldoNeto { get; set; }
        public int CantidadHijos { get; set; }
        public bool Casado { get; set; }

        public Double CalcularGastosFijos()
        {
            double GastoFijo = 0;
            double Sueldo = 0;

            if (Casado == true)
            {
                Sueldo = SueldoNeto - SueldoNeto * 0.2;
                GastoFijo = Sueldo - Sueldo * 0.05 * CantidadHijos;
                return GastoFijo;
            }
            else
            {
                GastoFijo = SueldoNeto - SueldoNeto * 0.05 * CantidadHijos;
            }
            return GastoFijo;
        
        }
        public virtual double ObtenerTasa()
        {
            return 0.15;
        }
        public virtual double CalcularMontoMaximoPrestamo()
        {
            return SueldoNeto - this.CalcularGastosFijos();
        }
        

    }
}
