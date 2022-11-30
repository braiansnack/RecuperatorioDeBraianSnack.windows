using ParcialDeBraianSnack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialDeBraianSnack.Datos
{
    public class RepositorioDeCubos
    {
        private List<Cubo> listaCubo;
        private bool hayCambios = false;

        public RepositorioDeCubos()
        {
            listaCubo = new List<Cubo>();
        }

        public void Agregar(Cubo cubo)
        {
            listaCubo.Add(cubo);
            hayCambios = true;
        }

        public void Borrar (Cubo cubo)
        {
            listaCubo.Remove(cubo);
            hayCambios = true;
        }
        public void Editar(Cubo cubo)
        {
            hayCambios = true;
        }



        public int GetCantidad()
        {
            return listaCubo.Count;
        }

        public List<Cubo> GetLista()
        {
            return listaCubo;
        }

        public List<Cubo> GetListaOrdenadaAsc()
        {
            return listaCubo.OrderBy(e => e.Arista).ToList();
        }

        public List<Cubo> GetListaOrdenadaDesc()
        {
            return listaCubo.OrderByDescending(e => e.Arista).ToList();
        }

        public List<Cubo> FiltrarPorTrazo(Trazo trazoFiltrar)
        {
            return listaCubo.Where(e => e.Trazo == trazoFiltrar).ToList();
        }

        public void GuardarEnArchivo()
        {
            if (hayCambios)
            {
                ManejadorDeArchivo.GuardarEnArchivo(listaEsferas);
            }
        }
    }
}
