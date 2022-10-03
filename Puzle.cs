using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzleGame
{
    class Puzle
    {
        private int[] vector;
        private int contador;
        private int x;
        private int y;

        public Puzle()
        {
            this.contador = 0;

            this.vector = new int[15];

                for (int i = 0; i < 15; i++)
                {
                    this.vector[i] = 0;
                }
        }

        public Puzle(int contador, int x, int y)
        {
            this.contador = contador;
            this.x = x;
            this.y = y;
        }

        public int[] Vector {
            set {vector =value; }
            get {return vector; }
        }

        public int retornarValoresTabla(int i)
        {
            return vector[i];
        }

        public int Contador
        {
            set { contador = value; }
            get { return contador; }
        }

    }
}
