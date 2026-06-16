using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EXAMENSG
{
    class Matriz
    {

        const int MAXF = 50;
        const int MAXC = 50;

        private int[,] x;
        private int f, c;

        public Matriz()
        {
            x = new int[MAXF, MAXC];
            f = 0;
            c = 0;
        }

        public void CargarRandom(int nf, int nc, int a, int b)
        {
            int f1, c1;
            Random r = new Random();
            f = nf;
            c = nc;
            for (f1 = 1; f1 <= f; f1++)
            {
                for (c1 = 1; c1 <= c; c1++)
                {
                    x[f1, c1] = r.Next(a, b + 1);
                }
            }
        }

        public void Dim(int f1, int c1)
        {
            f = f1;
            c = c1;
        }

        public string Descargar()
        {
            int f1, c1;
            string s = "";

            for (f1 = 1; f1 <= f; f1++)
            {
                for (c1 = 1; c1 <= c; c1++)
                {
                    s = s + x[f1, c1] + "\x9";
                }
                s = s + "\xd" + "\xa";
            }
            return s;
        }


        //EXAMEN


        //PREGUNTA 1 
        public void SegmentarColumnasParImpar()
        {
            NEnt n1 = new NEnt();
            NEnt n2 = new NEnt();

            for (int c1 = 1; c1 <= c; c1++) // columna actual
            {
                for (int f1 = 1; f1 <= f - 1; f1++) // i
                {
                    for (int f2 = f1 + 1; f2 <= f; f2++) // j
                    {
                        n1.Cargar(x[f1, c1]);
                        n2.Cargar(x[f2, c1]);

                        if ((n1.VerifPar() == false && n2.VerifPar() == true) ||
                            (n1.VerifPar() == true && n2.VerifPar() == true && x[f1, c1] > x[f2, c1]) ||
                            (n1.VerifPar() == false && n2.VerifPar() == false && x[f1, c1] > x[f2, c1]))
                        {
                            intercambiar(f1, c1, f2, c1);
                        }
                    }
                }
            }
        }

        public void intercambiar(int f1, int c1, int f2, int c2)
        {
            int aux;

            aux = x[f1, c1];

            x[f1, c1] = x[f2, c2];
            x[f2, c2] = aux;
        }
        //PREGUNTA 2 

        public void Ejercicio2()
        {
            for (int i = 2; i <= f; i++)
            {
                for (int j = c - i + 2; j <= c; j++)
                {
                    for (int j2 = j + 1; j2 <= c; j2++)
                    {
                        if (x[i, j] > x[i, j2])
                        {
                            int aux = x[i, j];
                            x[i, j] = x[i, j2];
                            x[i, j2] = aux;
                        }
                    }
                }
            }
        }

       


    }
}
