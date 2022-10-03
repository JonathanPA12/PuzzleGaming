using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Quiz3_JuegoQuince
{
    class Registro
    {

        public void registro(Jugador jugador)
        {
            //agregar los datos del jugador al archivo
            TextWriter datos = new StreamWriter("Registro.txt", true); 
            datos.WriteLine("Jugador: {0} " +
                "\nFecha: {1} " +
                "\nMovimientos: {2} " +
                "\nResultado: {3}\n", jugador.NombreUsuario, jugador.MovimientosRealizados, jugador.ResultadoFinal);

            datos.Close();
        }
    }
}
