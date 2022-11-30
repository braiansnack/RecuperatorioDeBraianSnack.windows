using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParcialDeBraianSnack.Entidades;

namespace POOCircunferencia.Datos

{ class ManejadorDeArchivos
    {
        private static string archivo = "Cubos.text";

        public static void GuardarEnArchivo(List<Cubo> lista)
        {
            using (var escritor = new StreamWriter(archivo))
            {
                foreach (var cubo in lista)
                {
                    string linea = ConstuirLinea(cubo);
                    escritor.WriteLine(linea);
                }
            }
        }

        private static string ConstuirLinea(Cubo cubo)
        {
            return $"{cubo.Arista}|{(int)cubo.Relleno}|{(int)cubo.Trazo}";
        }

        public static List<Cubo> LeerDelArchivo()
        {
            List<Cubo> lista = new List<Cubo>();
            using (var lector = new StreamReader(archivo))
            {
                while (!lector.EndOfStream)
                {
                    string linea = lector.ReadLine();
                    Cubo esfera = CrearEsfera(linea);
                    lista.Add(esfera);
                }
            }

            return lista;
        }

        private static Cubo CrearEsfera(string linea)
        {
            var campos = linea.Split('|');
            Cubo esfera = new Cubo()
            {
                Arista = int.Parse(campos[0]),
                Relleno = (Relleno)int.Parse(campos[1]),
                Trazo = (Trazo)int.Parse(campos[2])
            };
            return esfera;
        }
    }
}

