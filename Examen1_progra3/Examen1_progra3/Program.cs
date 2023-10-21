using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_progra3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            while (true)
            {
                menu.MostrarMenu();
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        menu.AgregarEmpleado();
                        break;
                    case 2:
                        Console.WriteLine("Ingrese la cédula del empleado a consultar:");
                        string cedula = Console.ReadLine();
                        menu.ConsultarEmpleado(cedula);
                        break;
                    case 3:
                        Console.WriteLine("Ingrese la cédula del empleado a borrar:");
                        string cedulaBorrar = Console.ReadLine();
                        menu.BorrarEmpleado(cedulaBorrar);
                        break;
                    case 4:
                        Console.WriteLine("Ingrese la cédula del empleado a modificar:");
                        string cedulaModificar = Console.ReadLine();
                        menu.ModificarEmpleado(cedulaModificar);
                        break;
                    case 5:
                        menu.InicializarArreglos();
                        break;
                    case 6:
                        menu.GenerarReportes();
                        break;
                    case 7:
                        Environment.Exit(0); // Salir del programa
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}

