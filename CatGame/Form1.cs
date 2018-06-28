using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatGame
{
    public partial class Form1 : Form
    {
        public int intentos = 0;
        public int puntaje = 0;
        

        
        public Form1()
        {
            InitializeComponent();
            Perro.Visible = false;
            Hombre.Visible = false;
            Casa1.Visible = false;
            Supermercado.Visible = false;

        }



        private void comenzarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AltaNombre an = new AltaNombre();
            an.ShowDialog();
            string nombre = an.ObtenerNombre(); 
            Jugador jug = new Jugador(nombre);
            intentos = jug.Intentos;
            puntaje = jug.Puntaje;
            lblnombre.Text = nombre;

            tiempojuego.Enabled = true;
            tiempojuego.Interval = 100;
            if (tiempojuego.Enabled == true)
            {

                Cat.Location = new Point(201, 575);
                Cat.Visible = true;

                Random rdn = new Random();
                int a = rdn.Next(5, 407);
                int b = rdn.Next(5, 407);
                int c = rdn.Next(5, 407);
                Casa1.Location = new Point(a, 0);
                Hombre.Location = new Point(b, 0);
                Perro.Location = new Point(c, 0);


                tiempojuego.Start();
                lblintentos.Text = "Intentos 9";
                lblpuntaje.Text = "Puntaje 0";

            }

        }

        private void tiempojuego_Tick(object sender, EventArgs e)
        {
            Random rdn = new Random();
            int a = rdn.Next(5, 407);
            int b = rdn.Next(5, 407);
            int c = rdn.Next(5, 407);

           


            if ((Casa1.Top < 600) && (Hombre.Top < 600) && (Perro.Top < 600))
            {
                Casa1.Top = Casa1.Top + 16;
                Hombre.Top = Hombre.Top + 12;
                Perro.Top = Perro.Top + 13;

            }
            else
            {

                Casa1.Visible = true;
                Hombre.Visible = true;
                Perro.Visible = true;

                Casa1.Location = new Point(a, 0);
                Hombre.Location = new Point(b, 0);
                Perro.Location = new Point(c, 0);
            }


            if(Casa1.Visible == true)
            {
                if(Casa1.Bounds.IntersectsWith(Cat.Bounds))
                    {
                    Casa1.Visible = false;
                    puntaje += 100;
                    lblpuntaje.Text = "Puntaje: " + puntaje;
                }
            }

            if (Hombre.Visible == true)
            {
                if (Hombre.Bounds.IntersectsWith(Cat.Bounds))
                {
                    Hombre.Visible = false;
                    intentos = intentos - 1;
                    lblintentos.Text = "Intentos: " + intentos;
                }
            }

            if (Perro.Visible == true)
            {
                if (Perro.Bounds.IntersectsWith(Cat.Bounds))
                {
                    Perro.Visible = false;
                    intentos = intentos - 1;
                    lblintentos.Text = "Intentos: " + intentos;
                }
            }

            if (Supermercado.Visible == true)
            {
                if(Supermercado.Bounds.IntersectsWith(Cat.Bounds))
                {
                    tiempojuego.Stop();
                    ClearData();
                    MessageBox.Show("Juego Terminado, Ganó!! Llego al Supermercado!");
                    
                }
            }

            if(intentos == 0)
            {
                tiempojuego.Stop();
                MessageBox.Show("Juego Terminado, Perdio!");
                ClearData();

            }

            if(puntaje == 1000)
            {
                Supermercado.Visible = true;
                
                Supermercado.Location = new Point(200, 100);
                
            }

        }

         private void ClearData()
        {
            Perro.Visible = false;
            Hombre.Visible = false;
            Casa1.Visible = false;
            Supermercado.Visible = false;
            intentos = 9;
            lblintentos.Text = "Intentos 9";
            puntaje = 0;
            lblpuntaje.Text = "Puntaje 0";
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = Cat.Location.X;
            int y = Cat.Location.Y;


            if (e.KeyCode == Keys.Right)
            { x += 13; }
            if (e.KeyCode == Keys.Left)
            { x -= 13; }
            if (e.KeyCode == Keys.Up)
            { y -= 13; }
            if (e.KeyCode == Keys.Down)
            { y += 13; }

            Cat.Location = new System.Drawing.Point(x, y);
            
        }
    }
}

