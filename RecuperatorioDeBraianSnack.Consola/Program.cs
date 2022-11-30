using POOCubo.Datos;
using POOCubo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POOCubo.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositorioDeCubos repo = new RepositorioDeCubos();
            Cubo circ = new Cubo(20);
            repo.Agregar(circ);
            Console.WriteLine(circ.Area.ToString());
            Console.WriteLine(circ.GetArea());
            Console.WriteLine(circ.GetVolumen());
            Cubo circ2 = new Cubo() { Area=4};
            repo.Agregar(circ2);
            var circ3 = new Cubo();
            circ3.Area = -10;
            if (circ3.Validar())
            {
                repo.Agregar(circ3);
            }
            else
            {
                Console.WriteLine("[ERROR] no válido");
            }
            var lista = repo.GetLista();
            MostrarListaCir(lista);
            repo.Agregar(circ3);

            Console.ReadLine();

        }

        private static void MostrarListaCir(List<Cubo> lista)
        {
            foreach (var circ in lista)
            {
                Console.WriteLine(circ.Area);
            }
        }
    }
}
