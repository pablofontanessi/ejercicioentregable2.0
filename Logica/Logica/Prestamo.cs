using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Prestamo
    {
        public Cliente ClienteOtorgado { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public double MontoTotalCredito { get; set; }
        public decimal TasaInteresOtorgada{ get; set; }
        public int CantCuotasPrestamos { get; set; }
        public double MontoCuotas { get; set; }

        public List<Prestamo> RegistrarUnPrestamo(List<Prestamo> ListaPrestamos, Cliente pCliente, DateTime pFechaPrestamo, double pMontoT, decimal pTasa, int pCantCuot)
        {

            Prestamo NuevoPrestamo = new Prestamo();
            NuevoPrestamo.ClienteOtorgado = pCliente;
            NuevoPrestamo.FechaPrestamo = pFechaPrestamo;
            NuevoPrestamo.MontoTotalCredito = pMontoT;
            NuevoPrestamo.TasaInteresOtorgada = pTasa;
            NuevoPrestamo.CantCuotasPrestamos = pCantCuot;
            NuevoPrestamo.MontoCuotas = (pMontoT * pCliente.ObtenerTasa()) / pCantCuot;
            ListaPrestamos.Add(NuevoPrestamo);
            return ListaPrestamos;
        }
    }
}
