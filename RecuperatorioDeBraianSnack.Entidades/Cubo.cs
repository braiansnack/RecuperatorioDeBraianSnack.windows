using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialDeBraianSnack.Entidades
{
    public  class Cubo
    {
        public int Arista { get; set; }
        public Relleno Relleno { get; set; }
        public Trazo Trazo { get; set; }

        public Cubo()
        {

        }

        public double GetArea()
        {
            return 6*Math.Pow(Arista,2);
        }

        public double GetVolumen() => Math.Pow(Arista, 3);
            
        public bool Validar()
        {
            return Arista > 0;
        }



    }
}
