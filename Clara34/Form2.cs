using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clara34
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Productos producto;

        private void button2_Click(object sender, EventArgs e)
        {
            producto = new Productos(textBoxNombre.Text, textBoxCategoria.Text, textBoxDescripcion.Text, Int32.Parse(textBoxPrecio.Text) );
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    }
}
