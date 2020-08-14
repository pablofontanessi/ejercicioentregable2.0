using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Empleado
    {

        private int DNIEmpleado { get; set; }
        private string NombreEmpleado { get; set; }
        private DateTime FechaNacimiento { get; set; }
        private double SueldoBruto { get; set; }
        private DateTime FechaIngreso { get; set; }
        private string Seccion { get; set; }

        //Metodos
        public void CargarFechaIngreso(DateTime pFechaIngreso)
        {
            FechaIngreso = pFechaIngreso;
        }
        public DateTime ObtenerFechaIngreso()
        {
            return FechaIngreso;
        }
        public void CargarFechaNacimiento(DateTime pFechaNacimiento)
        {
            FechaNacimiento = pFechaNacimiento;
        }
        public DateTime ObtenerFechaNacimiento()
        {
            return FechaNacimiento;
        }
        public void CargarNombreEmpleado(string pNombreEmpleado)
        {
            NombreEmpleado = pNombreEmpleado;
        }
        public string ObtenerNombreEmpleado()
        {
            return NombreEmpleado;
        }
        public void CargarDNIEmpleado(int pDni)
        {
            DNIEmpleado = pDni;
        }
        public int ObtenerDNIEmpleado()
        {
            return DNIEmpleado;
        }

        public void CargarSeccion(string pSeccion)
        {
            Seccion = pSeccion;
        }
        public string ObtenerSeccion()
        {
            return Seccion;
        }
        public void CargarSueldoBruto(double pSueldoBruto)
        {
            SueldoBruto = pSueldoBruto;
        }
        public double ObtenerSueldoBruto()
        {
            return SueldoBruto;
        }
        //METODOS GENERALES
        public int ObtenerEdad()
        {
            int Edad;
            TimeSpan fechaEd = DateTime.Today - FechaNacimiento;
            Edad = int.Parse(fechaEd.ToString());
            return Edad;
        }
        public int ObtenerAntiguedad()
        {
            TimeSpan aniosantiguedad = DateTime.Today - FechaIngreso;
            int Antiguedad = int.Parse(aniosantiguedad.ToString());

            return Antiguedad;
        }
    }
}
