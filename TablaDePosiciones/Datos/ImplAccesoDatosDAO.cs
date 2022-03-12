using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TablaDePosiciones.Datos
{

    class ImplAccesoDatosDAO : InterfazAccesoDatos
    {
        private static string _path = @"C:\tmp\archivo.json";

        public bool escribirDatos(List<Equipo> listaEquipos)
        {
            try
            {
                File.WriteAllText(_path, SerializarJsonFile(listaEquipos));
                return true;
            } 
            catch (Exception e)
            {
                Console.WriteLine("Error al escribir el archivo: " + e);
            }
            return false;
        }

        public List<Equipo> leerDatos()
        {
            string listaJson = null;
            try
            {
                using (var reader = new StreamReader(_path))
                {
                    listaJson = reader.ReadToEnd();
                }
            } catch (Exception e)
            {
                Console.WriteLine("Error al leer el archivo: " + e);
            }
            return DeserializarJsonFile(listaJson);
        }

        public static string SerializarJsonFile(List<Equipo> listaEquipos)
        {
            return JsonConvert.SerializeObject(listaEquipos, Formatting.Indented); 
        }
        public static List<Equipo> DeserializarJsonFile(string listaSerializada)
        {
            return JsonConvert.DeserializeObject<List<Equipo>>(listaSerializada);
        }
    }
}
