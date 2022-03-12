using System;
using TablaDePosiciones.Negocios;

namespace TablaDePosiciones
{
    class Program
    {
        public static void Main()
        {
            Tabla tabla = new Tabla();
            string[,] datos;
            bool salir=false;

            while (!salir) {
                Console.WriteLine("\n-----------------------");
                Console.WriteLine("1. Agregar Partido");
                Console.WriteLine("2. Desplegar Tabla");
                Console.WriteLine("3. Salir");
                Console.WriteLine("-----------------------\n");
                Console.Write("Elige una de las opciones: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------------\n");
                switch (opcion)
                {
                    case 1:
                        datos = tabla.obtenerResultadosEquipo();
                        string[] local = new string[3];
                        string[] visitante = new string[3];     
                        for(int j = 0; j < datos.GetLength(1); j++)
                        {
                            local[j] = datos[0,j];
                            visitante[j] = datos[1, j];
                        }
                        tabla.agregarDatosALaTabla(local,"l");
                        tabla.agregarDatosALaTabla(visitante, "v");
                        break;
                    case 2:
                        tabla.imprimirMatrizDeEquipos();
                        break;
                    case 3:
                        Console.WriteLine("Saliste de la aplicación");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion valida.");
                        break;
                }
            }
        }
    }
}