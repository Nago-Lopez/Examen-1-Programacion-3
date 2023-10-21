using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_progra3
{
    internal class ClsEmpleado
    {
        // Atributos de la clase Empleado
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public double Salario { get; set; }

        // Constructor para inicializar los atributos
        public ClsEmpleado(string cedula, string nombre, string direccion, string telefono, double salario)
        {
            Cedula = cedula;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Salario = salario;
        }
    }

    class Menu
    {
        List<ClsEmpleado> empleados = new List<ClsEmpleado>();

        // Método para mostrar el menú
        public void MostrarMenu()
        {
            Console.WriteLine("Menú de Opciones:");
            Console.WriteLine("1. Agregar empleado");
            Console.WriteLine("2. Consultar empleado");
            Console.WriteLine("3. Borrar empleado");
            Console.WriteLine("4. Modificar empleado");
            Console.WriteLine("5. Inicializar Arreglos");
            Console.WriteLine("6. Reportes");
            Console.WriteLine("7. Salir");
        }

        // Método para agregar un empleado
        public void AgregarEmpleado()
        {
            Console.WriteLine("Ingrese la cédula del empleado:");
            string cedula = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del empleado:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la dirección del empleado:");
            string direccion = Console.ReadLine();
            Console.WriteLine("Ingrese el teléfono del empleado:");
            string telefono = Console.ReadLine();
            Console.WriteLine("Ingrese el salario del empleado:");
            double salario = Convert.ToDouble(Console.ReadLine());

            ClsEmpleado empleado = new ClsEmpleado(cedula, nombre, direccion, telefono, salario);
            empleados.Add(empleado);
            Console.WriteLine("Empleado agregado con éxito.");
        }

        // Método para consultar un empleado
        public void ConsultarEmpleado(string cedula)
        {
            ClsEmpleado empleado = empleados.Find(e => e.Cedula == cedula);
            if (empleado != null)
            {
                Console.WriteLine("Información del empleado:");
                Console.WriteLine($"Cédula: {empleado.Cedula}");
                Console.WriteLine($"Nombre: {empleado.Nombre}");
                Console.WriteLine($"Dirección: {empleado.Direccion}");
                Console.WriteLine($"Teléfono: {empleado.Telefono}");
                Console.WriteLine($"Salario: {empleado.Salario}");
            }
            else
            {
                Console.WriteLine("Empleado no encontrado.");
            }
        }

        // Método para borrar un empleado
        public void BorrarEmpleado(string cedula)
        {
            ClsEmpleado empleado = empleados.Find(e => e.Cedula == cedula);
            if (empleado != null)
            {
                empleados.Remove(empleado);
                Console.WriteLine("Empleado eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("Empleado no encontrado.");
            }
        }

        // Método para modificar un empleado
        public void ModificarEmpleado(string cedula)
        {
            ClsEmpleado empleado = empleados.Find(e => e.Cedula == cedula);
            if (empleado != null)
            {
                Console.WriteLine("Ingrese el nuevo nombre del empleado:");
                empleado.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la nueva dirección del empleado:");
                empleado.Direccion = Console.ReadLine();
                Console.WriteLine("Ingrese el nuevo teléfono del empleado:");
                empleado.Telefono = Console.ReadLine();
                Console.WriteLine("Ingrese el nuevo salario del empleado:");
                empleado.Salario = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Empleado modificado con éxito.");
            }
            else
            {
                Console.WriteLine("Empleado no encontrado.");
            }
        }

        // Método para inicializar arreglos (Limpia el sistema)
        public void InicializarArreglos()
        {
            empleados.Clear();
            Console.WriteLine("La lista de empleados ha sido inicializada.");
        }

        // Método para generar reportes
        public void GenerarReportes()
        {
            Console.WriteLine("Menú de Reportes:");
            Console.WriteLine("1. Consultar empleados con número de cédula");
            Console.WriteLine("2. Listar todos los empleados ordenados por nombre");
            Console.WriteLine("3. Calcular y mostrar el promedio de los salarios");
            Console.WriteLine("4. Calcular y mostrar el salario más alto y el más bajo");
            Console.WriteLine("5. Regresar al menú principal");

            int opcionReportes = Convert.ToInt32(Console.ReadLine());

            switch (opcionReportes)
            {
                case 1:
                    Console.WriteLine("Ingrese la cédula del empleado a consultar:");
                    string cedula = Console.ReadLine();
                    ConsultarEmpleado(cedula);
                    break;
                case 2:
                    ListarEmpleadosOrdenadosPorNombre();
                    break;
                case 3:
                    CalcularPromedioSalarios();
                    break;
                case 4:
                    CalcularSalarioMasAltoYMasBajo();
                    break;
                case 5:
                    // Regresar al menú principal
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        // Método para listar todos los empleados ordenados por nombre
        public void ListarEmpleadosOrdenadosPorNombre()
        {
            List<ClsEmpleado> empleadosOrdenados = empleados.OrderBy(e => e.Nombre).ToList();
            Console.WriteLine("Empleados ordenados por nombre:");
            foreach (ClsEmpleado empleado in empleadosOrdenados)
            {
                Console.WriteLine($"Cédula: {empleado.Cedula}, Nombre: {empleado.Nombre}");
            }
        }

        // Método para calcular y mostrar el promedio de los salarios
        public void CalcularPromedioSalarios()
        {
            double promedio = empleados.Average(e => e.Salario);
            Console.WriteLine($"El promedio de los salarios es: {promedio}");
        }

        // Método para calcular y mostrar el salario más alto y el más bajo
        public void CalcularSalarioMasAltoYMasBajo()
        {
            double salarioMasAlto = empleados.Max(e => e.Salario);
            double salarioMasBajo = empleados.Min(e => e.Salario);
            Console.WriteLine($"Salario más alto: {salarioMasAlto}");
            Console.WriteLine($"Salario más bajo: {salarioMasBajo}");
        }
    }

}
