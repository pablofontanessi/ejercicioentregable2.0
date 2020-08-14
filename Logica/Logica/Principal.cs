using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Principal
    {
        List<Empleados> ListaEmpleados = new List<Empleados>();

        public double ObtenerSueldoNeto(int pDNIempleado)
        {
            double SueldoNeto = 0;
            foreach (var empleado in ListaEmpleados)
            {
                if (empleado.ObtenerDNIEmpleado() == pDNIempleado)
                {
                    switch (empleado.ObtenerSeccion())
                    {
                        case "A":
                            SueldoNeto = empleado.ObtenerSueldoBruto() * 0.8;
                            break;
                        case "P":
                            SueldoNeto = empleado.ObtenerSueldoBruto() - (empleado.ObtenerSueldoBruto() * 0.02) * empleado.ObtenerAntiguedad();
                            break;
                        case "V":
                            if (empleado.ObtenerAntiguedad() <= 5)
                            {
                                SueldoNeto = empleado.ObtenerSueldoBruto();
                            }
                            else
                            {
                                SueldoNeto = empleado.ObtenerSueldoBruto() - (empleado.ObtenerSueldoBruto() * 0.03) * empleado.ObtenerAntiguedad();
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            return SueldoNeto;
        }

        public bool CarganNuevoEmpleado(int pDni, string pNombre, double pSueldoBruto, DateTime pFechaNac, DateTime pFechaIngreso, string pSeccion)
        {
            bool Exitoso = false;
            foreach (var Empleado in ListaEmpleados)
            {
                if (pDni == Empleado.ObtenerDNIEmpleado())
                {
                    return Exitoso;
                }
                else
                {
                    Empleados EmpleadoNuevo = new Empleados();
                    EmpleadoNuevo.CargarDNIEmpleado(pDni);
                    EmpleadoNuevo.CargarNombreEmpleado(pNombre);
                    EmpleadoNuevo.CargarSeccion(pSeccion);
                    EmpleadoNuevo.CargarSueldoBruto(pSueldoBruto);
                    EmpleadoNuevo.CargarFechaNacimiento(pFechaNac);
                    EmpleadoNuevo.CargarFechaIngreso(pFechaIngreso);
                    ListaEmpleados.Add(EmpleadoNuevo);
                    return Exitoso = true;
                }
            }


            return Exitoso;

        }

        public double DesvincularEmpleado(int pDNI)
        {
            double Indenmizacion = 0;
            foreach (var empleado in ListaEmpleados)
            {
                if (empleado.ObtenerDNIEmpleado() == pDNI)
                {

                    Indenmizacion = 2 * empleado.ObtenerSueldoBruto() * empleado.ObtenerAntiguedad();
                    ListaEmpleados.Remove(empleado);
                    return Indenmizacion;
                }
            }
            return Indenmizacion;
        }
        public List<Filtrado> ObtenerListadoPorSeccion(string pSeccion)
        {
            List<Filtrado> ListadoPorSeccion = new List<Filtrado>();
            foreach (var empleado in ListaEmpleados)
            {
                if (empleado.ObtenerSeccion() == pSeccion)
                {
                    Filtrado EmpleadoConCat = new Filtrado();
                    EmpleadoConCat.Antiguedad = empleado.ObtenerAntiguedad();
                    EmpleadoConCat.Antiguedad = empleado.ObtenerEdad();
                    EmpleadoConCat.Nombre = empleado.ObtenerNombreEmpleado();
                    EmpleadoConCat.Seccion = empleado.ObtenerSeccion();
                    ListadoPorSeccion.Add(EmpleadoConCat);

                }
            }
            ListadoPorSeccion.OrderByDescending(Filtrado.Antiguedad); //No pude encontrar como ordenar por este metodo
            return ListadoPorSeccion;
        }
    }
}
