using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENSG
{
    class NEnt
    {
        private int n;
        public NEnt()
        {
            n = 0;
        }
        public void Cargar(int dato)
        {
            n = dato;
        }
        public int descargar()
        {
            return n;
        }

       
        public bool VerifPar()
        {
            return n % 2 == 0;
        }

      

    }
}
