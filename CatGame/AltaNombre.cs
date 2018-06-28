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
    public partial class AltaNombre : Form
    {
        private string nombre;

        public string Nombre { get => nombre; set => nombre = value; }

        public AltaNombre()
        {
            InitializeComponent();
            Nombre = "";
        }

        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Nombre = txtboxnombre.Text;
            Close();
        }

        public string ObtenerNombre()
        {
            return Nombre;
        }
    }
}
