using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3_JuegoQuince
{
    class Jugador
    {
        private string nombreUsuario;
        private string resultadoFinal;//Victoria o derrota
        private int movimientosRealizados;
        

        public Jugador()
        {
            this.nombreUsuario = " ";
            this.resultadoFinal = " ";
            this.movimientosRealizados = 0;
        
        }

        public Jugador(string nombreUsuario, string resultadoFinal, int movimientosRealizados, string fecha)
        {
            this.nombreUsuario = nombreUsuario;
            this.resultadoFinal = resultadoFinal;
            this.movimientosRealizados = movimientosRealizados;
           
        }

        public string NombreUsuario
        {
            set { nombreUsuario = value; }
            get { return nombreUsuario; }
        }

        public string ResultadoFinal
        {
            set { resultadoFinal = value; }
            get { return resultadoFinal; }
        }

        public int MovimientosRealizados
        {
            set { movimientosRealizados = value; }
            get { return movimientosRealizados; }
        }

       

        public string JugadorToString()
        {
            string datos = "Nombre: " + nombreUsuario + "\nResultado final: " + resultadoFinal + "\nMovimientos realizados: " + movimientosRealizados + "\n";
            return datos;
        }
    }
}
