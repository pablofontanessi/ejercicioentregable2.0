using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Principal
    {
        List<Cliente> ListaClientes = new List<Cliente>();
        List<Prestamo> ListaPrestamos = new List<Prestamo>();
        public bool RegistrarPrestamo(int pCuitCliente, DateTime pFechaDePrestamo, double pMontoTotal, decimal pTasaInt, int pCantCuotas    )
        {
            Cliente ClienteSolicitante = new Cliente();
            foreach (var cliente in ListaClientes)
            {
                if (cliente.Cuit == pCuitCliente)
                {
                    ClienteSolicitante = cliente;
                }
                else
                {
                    return false;
                }
            }
            if (ClienteSolicitante != null & pFechaDePrestamo <= DateTime.Today & ClienteSolicitante.CalcularMontoMaximoPrestamo() <= pMontoTotal)
            {
                Prestamo RegistroPrestamo = new Prestamo();
                ListaPrestamos = RegistroPrestamo.RegistrarUnPrestamo(ListaPrestamos, ClienteSolicitante,pFechaDePrestamo, pMontoTotal,pTasaInt, pCantCuotas );
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<PrestamoFiltrado> ObtenerListaPrestamosEn2Fechas(DateTime pFechaMenor, DateTime pFechaMayor)
        {
            List<PrestamoFiltrado> ListaPrestamoFiltrado = new List<PrestamoFiltrado>();
            PrestamoFiltrado PrestamoFiltrado = new PrestamoFiltrado();
            foreach (var prestamo in ListaPrestamos)
            {
                if (prestamo.FechaPrestamo >= pFechaMenor | prestamo.FechaPrestamo <= pFechaMayor )
                {
                    PrestamoFiltrado.FechaPrestamo = prestamo.FechaPrestamo;
                    PrestamoFiltrado.Monto = prestamo.MontoTotalCredito;
                    PrestamoFiltrado.TasaInteres = prestamo.TasaInteresOtorgada;
                    PrestamoFiltrado.NombreCli = prestamo.ClienteOtorgado.Nombre +" " + prestamo.ClienteOtorgado.Apellido;
                    ListaPrestamoFiltrado.Add(PrestamoFiltrado);
                }
            }
            return ListaPrestamoFiltrado;
        }
    }
}
