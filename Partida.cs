using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Quiz3_JuegoQuince;

namespace PuzleGame
{
    class Partida
    {
        private Puzzle juego;
        private FormJugador login;
        private Puzle puzzle;
        private Jugador jugador;
        Button[] botones;

        public Partida()
        {
            juego = new Puzzle();
            login = new FormJugador();
            puzzle = new Puzle();
            jugador = new Jugador();
            botones = new Button[] 
            { juego.b1, juego.b2,
                juego.b3, juego.b4, 
                juego.b5, juego.b6, 
                juego.b7, juego.b8, 
                juego.b9, juego.b10, 
                juego.b11, juego.b12, 
                juego.b13, juego.b14, juego.b15 };

            inicio();
            Application.Run(login);
            Application.Run(juego);

        }
        void inicio()
        {
            Eventos();
            llenarBotones();
            frontEnd();
        }
        void Eventos()
        {
            //Eventos Formulario Usuario
            login.button1.Click += new System.EventHandler(this.button1_Click);
            login.button2.Click += new System.EventHandler(this.button2_Click);
            login.about.Click += new System.EventHandler(this.about_Click);

            //Eventos Formulario Juego
            juego.b16.Click += new System.EventHandler(this.b16_Click);
            juego.b15.Click += new System.EventHandler(this.b15_Click);
            juego.b14.Click += new System.EventHandler(this.b14_Click);
            juego.b13.Click += new System.EventHandler(this.b13_Click);
            juego.b12.Click += new System.EventHandler(this.b12_Click);
            juego.b11.Click += new System.EventHandler(this.b11_Click);
            juego.b10.Click += new System.EventHandler(this.b10_Click);
            juego.b9.Click += new System.EventHandler(this.b9_Click);
            juego.b8.Click += new System.EventHandler(this.b8_Click);
            juego.b7.Click += new System.EventHandler(this.b7_Click);
            juego.b6.Click += new System.EventHandler(this.b6_Click);
            juego.b5.Click += new System.EventHandler(this.b5_Click);
            juego.b4.Click += new System.EventHandler(this.b4_Click);
            juego.b3.Click += new System.EventHandler(this.b3_Click);
            juego.b2.Click += new System.EventHandler(this.b2_Click);
            juego.b1.Click += new System.EventHandler(this.b1_Click);
            
            juego.terminarJuego.Click += new System.EventHandler(this.terminarJuego_Click);
            juego.information.Click += new System.EventHandler(this.information_Click);
            juego.Solution.Click += new System.EventHandler(this.Solution_Click);
            
        }
        
        
        
        public void frontEnd()
        {
            juego.StartPosition = FormStartPosition.CenterScreen;
            login.StartPosition = FormStartPosition.CenterScreen;

            login.button1.BackColor = Color.Purple;
            login.button1.ForeColor = Color.White;
            login.button1.Text = "Login";
            ((Button)login.button1).Font = new Font("Roboto", 8, FontStyle.Bold);
            login.button2.BackColor = Color.Purple;
            login.button2.ForeColor = Color.White;
            ((Button)login.button2).Font = new Font("Roboto", 8, FontStyle.Bold);
            login.button2.Text = "Exit";
            login.BackColor = Color.Black;
            login.JugadorName.ForeColor = Color.BlueViolet;
            ((Label)login.JugadorName).Font = new Font("Verdana", 20, FontStyle.Bold);
            login.about.BackColor = Color.Purple;
            login.about.ForeColor = Color.White;
            ((Button)login.about).Font = new Font("Roboto", 8, FontStyle.Bold);



            juego.terminarJuego.ForeColor = Color.Yellow;
            juego.terminarJuego.BackColor = Color.Purple;
            ((Button)juego.terminarJuego).Font = new Font("Roboto", 9, FontStyle.Bold);
            juego.BackColor = Color.Black;
            juego.Solution.ForeColor = Color.Yellow;
            juego.Solution.BackColor = Color.Purple;
            ((Button)juego.Solution).Font = new Font("Roboto", 8, FontStyle.Bold);
            juego.information.ForeColor = Color.Yellow;
            juego.information.BackColor = Color.Purple;
            ((Button)juego.information).Font = new Font("Roboto", 8, FontStyle.Bold);


            juego.label1.Text = "Movimientos";
            juego.label2.Text = Convert.ToString(jugador.MovimientosRealizados);
            juego.label1.ForeColor = Color.White;
            juego.label2.ForeColor = Color.White;
            ((Label)juego.label1).Font = new Font("Roboto", 12, FontStyle.Bold);
            ((Label)juego.label2).Font = new Font("Roboto", 20, FontStyle.Bold);

        }

        public void llenarBotones()
        {

            llenarMatriz();

            

            for (int i = 0; i < botones.Length; i++)
            {
                botones[i].Text = puzzle.Vector[i].ToString();
                botones[i].BackColor = Color.Purple;
                botones[i].ForeColor = Color.White;
                ((Button)botones[i]).Font = new Font("Roboto", 15, FontStyle.Bold);
            }

            juego.b16.Visible = false;
            juego.b16.BackColor = Color.Purple;
            juego.b16.ForeColor = Color.White;
            ((Button)juego.b16).Font = new Font("Roboto", 15, FontStyle.Bold);

            juego.terminarJuego.BackColor = Color.Chocolate;
            juego.terminarJuego.ForeColor = Color.Black;

        }

        public void verificarGane()
        {
            if (juego.b1.Text == "1" && juego.b2.Text == "2" && 
                juego.b3.Text == "3" && juego.b4.Text == "4" &&
                juego.b5.Text == "5" && juego.b6.Text == "6" && 
                juego.b7.Text == "7" && juego.b8.Text == "8" &&
                juego.b9.Text == "9" && juego.b10.Text == "10" && 
                juego.b11.Text == "11" && juego.b12.Text == "12" &&
                juego.b13.Text == "13" && juego.b14.Text == "14" &&
                juego.b15.Text == "15")
            {
                MessageBox.Show("Felicidades");
                jugador.ResultadoFinal = "Ganador";
                terminarJuego();
            }
            
        }

        void verificarEspacioVacio(Button btn1, Button btn2)
        {
            if (btn2.Text==" ")
            {
                btn2.Text = btn1.Text;
                btn2.Visible = true;
                
                btn1.Text = " ";
                btn1.Visible = false;

                jugador.MovimientosRealizados++;
                juego.label2.Text = Convert.ToString(jugador.MovimientosRealizados);
            }
        }

        public int verificarAleatorios(int num)
        {

            for (int i = 0; i < 15; i++)
            {
                if (num == puzzle.Vector[i])
                {
                    return 0;
                }
            }

            return 1;
        }

        public void llenarMatriz()
        {
            Random ramdon = new Random();


            int num;
            for (int i = 0; i < 15; i++)
            {
                num = ramdon.Next(1, 15);
                while (verificarAleatorios(num) == 0)
                {
                    num = ramdon.Next(1, 16);
                }
                puzzle.Vector[i] = num;
            }
        }
        //inscribir en un txt los datos del jugador
        public void registro(Jugador jugador)
            {
              
                TextWriter datos = new StreamWriter("Registro.txt", true); //Se le agrega el true para que no sobreescriba el archivo, solo agregue datos
                datos.WriteLine(jugador.JugadorToString());

                datos.Close();
            }
        //terminar el juego y guardar el registro
        public void terminarJuego() {
            juego.b1.BackColor = Color.PaleTurquoise;
            juego.b1.Enabled = false;
            juego.b2.BackColor = Color.PaleTurquoise;
            juego.b2.Enabled = false;
            juego.b3.BackColor = Color.PaleTurquoise;
            juego.b3.Enabled = false;
            juego.b4.BackColor = Color.PaleTurquoise;
            juego.b4.Enabled = false;
            juego.b5.BackColor = Color.PaleTurquoise;
            juego.b5.Enabled = false;
            juego.b6.BackColor = Color.PaleTurquoise;
            juego.b6.Enabled = false;
            juego.b7.BackColor = Color.PaleTurquoise;
            juego.b7.Enabled = false;
            juego.b8.BackColor = Color.PaleTurquoise;
            juego.b8.Enabled = false;
            juego.b9.BackColor = Color.PaleTurquoise;
            juego.b9.Enabled = false;
            juego.b10.BackColor = Color.PaleTurquoise;
            juego.b10.Enabled = false;
            juego.b11.BackColor = Color.PaleTurquoise;
            juego.b11.Enabled = false;
            juego.b12.BackColor = Color.PaleTurquoise;
            juego.b12.Enabled = false;
            juego.b13.BackColor = Color.PaleTurquoise;
            juego.b13.Enabled = false;
            juego.b14.BackColor = Color.PaleTurquoise;
            juego.b14.Enabled = false;
            juego.b15.BackColor = Color.PaleTurquoise;
            juego.b15.Enabled = false;
            juego.b16.BackColor = Color.PaleTurquoise;
            juego.b16.Enabled = false;

            registro(jugador);

            MessageBox.Show("Partida Guardada");
        }



        // Eventos de los botones del juego 
        private void b1_Click(object sender, EventArgs e)
        {
            verificarEspacioVacio(juego.b1, juego.b2);
            verificarEspacioVacio(juego.b1, juego.b5);
            verificarGane();
        }
        private void information_Click(object sende, EventArgs e)
        {
            //mostrar un mensaje de ayuda
            MessageBox.Show("El objetivo del juego es ordenar los" +
                " numeros de 1 a 15 de forma ascendente, para ello se " +
                "debe mover los numeros con el espacio vacio" +
                "puedes moverte de arriba, abajo, izquierda y derecha" +
                "dependiendo tu posicion. Tambien puede utilizar el click del" +
                "mouse para moverte:" +
                "Este juego fue desarrollado por Mauren Quesada y Jonathan Pineda");
        }
        private void about_Click(object sende, EventArgs e)
        {
            //mostrar un mensaje de ayuda
            MessageBox.Show("El JUEGO QUINCE \n" +
                "Para el desarrollo de este juego se toma en cuenta lo siguente:\n" +
                "\t 1. La aplicación utiliza la arquitectura de Modelo-Vista-Controldador.\n" +
                "\t 2. Genera el llenado desordenado (aleatorio) del puzle con todos los numeros del 1 al 15.\n" +
                "\t 3. Al mover las casillas actualiza la vista automaticamente.\n" +
                "\t 4. El juego valida que sólo las casillas correctas puedan moverse.\n" +
                "\t 5. El juego realiza el conteo de lo movimientos.\n" +
                "\t 6. El juego lleva un registro de los jugadores.\n" +
                "\t 7. Muestra la solucion del juego.\n" +
                "\t 8. Tiene su seccion de ayuda.");

        }


        private void Solution_Click(object sende, EventArgs e)
        {
            //mostrar la solucion del juego
           /* MessageBox.Show("1 2 3 4" +
                "5 6 7 8" +
                "9 10 11 12" +
                "13 14 15");*/
            //ordenar los botones y mostrar la solucion
            juego.b1.Text = "1";
            juego.b2.Text = "2";
            juego.b3.Text = "3";
            juego.b4.Text = "4";
            juego.b5.Text = "5";
            juego.b6.Text = "6";
            juego.b7.Text = "7";
            juego.b8.Text = "8";
            juego.b9.Text = "9";
            juego.b10.Text = "10";
            juego.b11.Text = "11";
            juego.b12.Text = "12";
            juego.b13.Text = "13";
            juego.b14.Text = "14";
            juego.b15.Text = "15";
            juego.b16.Text = " ";




        }

        private void b2_Click(object sender, EventArgs e)
        {
            verificarEspacioVacio(juego.b2, juego.b1);
            verificarEspacioVacio(juego.b2, juego.b3);
            verificarEspacioVacio(juego.b2, juego.b6);
            verificarGane();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            verificarEspacioVacio(juego.b3, juego.b2);
            verificarEspacioVacio(juego.b3, juego.b4);
            verificarEspacioVacio(juego.b3, juego.b7);
            verificarGane();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            verificarEspacioVacio(juego.b4, juego.b3);
            verificarEspacioVacio(juego.b4, juego.b8);
            verificarGane();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            verificarEspacioVacio(juego.b5, juego.b1);
            verificarEspacioVacio(juego.b5, juego.b6);
            verificarEspacioVacio(juego.b5, juego.b9);
            verificarGane();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            verificarEspacioVacio(juego.b6, juego.b2);
            verificarEspacioVacio(juego.b6, juego.b5);
            verificarEspacioVacio(juego.b6, juego.b7);
            verificarEspacioVacio(juego.b6, juego.b10);
            verificarGane();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            verificarEspacioVacio(juego.b7, juego.b3);
            verificarEspacioVacio(juego.b7, juego.b6);
            verificarEspacioVacio(juego.b7, juego.b8);
            verificarEspacioVacio(juego.b7, juego.b11);
            verificarGane();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            verificarEspacioVacio(juego.b8, juego.b4);
            verificarEspacioVacio(juego.b8, juego.b7);
            verificarEspacioVacio(juego.b8, juego.b12);
            verificarGane();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            verificarEspacioVacio(juego.b9, juego.b5);
            verificarEspacioVacio(juego.b9, juego.b10);
            verificarEspacioVacio(juego.b9, juego.b13);
            verificarGane();
        }

        private void b10_Click(object sender, EventArgs e)
        {
            verificarEspacioVacio(juego.b10, juego.b6);
            verificarEspacioVacio(juego.b10, juego.b9);
            verificarEspacioVacio(juego.b10, juego.b11);
            verificarEspacioVacio(juego.b10, juego.b14);
            verificarGane();
        }

        private void b11_Click(object sender, EventArgs e)
        {
            verificarEspacioVacio(juego.b11, juego.b7);
            verificarEspacioVacio(juego.b11, juego.b10);
            verificarEspacioVacio(juego.b11, juego.b12);
            verificarEspacioVacio(juego.b11, juego.b15);
            verificarGane();
        }

        private void b12_Click(object sender, EventArgs e)
        {
            verificarEspacioVacio(juego.b12, juego.b8);
            verificarEspacioVacio(juego.b12, juego.b11);
            verificarEspacioVacio(juego.b12, juego.b16);
            verificarGane();
        }

        private void b13_Click(object sender, EventArgs e)
        {
            verificarEspacioVacio(juego.b13, juego.b9);
            verificarEspacioVacio(juego.b13, juego.b14);
            verificarGane();
        }

        private void b14_Click(object sender, EventArgs e)
        {
            verificarEspacioVacio(juego.b14, juego.b13);
            verificarEspacioVacio(juego.b14, juego.b10);
            verificarEspacioVacio(juego.b14, juego.b15);
            verificarGane();
        }

        private void b15_Click(object sender, EventArgs e)
        {
            verificarEspacioVacio(juego.b15, juego.b14);
            verificarEspacioVacio(juego.b15, juego.b11);
            verificarEspacioVacio(juego.b15, juego.b16);
            verificarGane();
        }

        private void b16_Click(object sender, EventArgs e)
        {
            verificarEspacioVacio(juego.b16, juego.b12);
            verificarEspacioVacio(juego.b16, juego.b15);
            verificarGane();
        }
        
        private void terminarJuego_Click(object sender, EventArgs e)
        {
            var closeMsg = MessageBox.Show("¿Salir?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (closeMsg == DialogResult.Yes)
            {
                jugador.ResultadoFinal = "Derrota";
                terminarJuego();

                Application.Restart();
                juego = new Puzzle();


            }
        }

        //eventos del formulario del jugador  por parte del login
        private void button1_Click(object sender, EventArgs e)
        {
            if (login.textBox1.Text != "")
            {
                jugador.NombreUsuario = login.textBox1.Text;
                login.Hide();
                juego.Refresh();
                juego.Show();
            }
            else
            {
                MessageBox.Show("No se puede dejar el campo vacio");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var closeMsg = MessageBox.Show("¿Salir?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (closeMsg == DialogResult.Yes)
            {
                Environment.Exit(1);
            }
        }
    }
}
