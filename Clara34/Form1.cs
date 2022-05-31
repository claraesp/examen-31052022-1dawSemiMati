namespace Clara34
{
    public partial class Form1 : Form
    {

        private String cliente;
        private int precio;
        private List<Productos> Productos { get; set; }
        public Form1()
        {
            InitializeComponent();

        }

         


        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            cliente = textBoxNombre.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
          

            if (form2.ShowDialog() == DialogResult.OK)
            {
               

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}