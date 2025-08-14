using ej1.Models;

namespace ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDescribir_Click(object sender, EventArgs e)
        {
            //construyendo los objetos

            //Cilindro objeto1 = new Cilindro(3, 3);
            //Cubo objeto2 = new Cubo(3);
            Ortoedro objeto3 = new Ortoedro(7, 7, 21);
            //Cilindro objeto4 = new Cilindro(9, 13);
            //Cubo objeto5 = new Cubo(7);
            //Cilindro objeto6 = new Cilindro(13, 23);

            //llamando al mensaje común de todos los objetos figura

            Rectangulo rect3 = new Rectangulo(3, 6);
            Rectangulo rect4 = new Rectangulo(3, 6);

            tbDescripcion.Text = $@"[{rect3.Describir()}, {objeto3.Describir()}]";

        }
}
}
