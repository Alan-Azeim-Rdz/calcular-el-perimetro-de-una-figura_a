namespace calcular_el_perimetro_de_una_figura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bcircle_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(radiustxt.Text);

            Circle rad = new Circle(radius);

            double PerimeterCircle = rad.perimeter1();

            // Mostrar el resultado
            MessageBox.Show($"the Perimeter for Circle is: {PerimeterCircle}");
        }

        private void Btriangle_Click(object sender, EventArgs e)
        {
            double side1 = double.Parse(side1txt.Text);
            double side2 = double.Parse(side2txt.Text);
            double side3 = double.Parse(side3txt.Text);

            Triangle side = new Triangle(side1, side2, side3);


            double PerimeterTriangle = side.perimeter1();

            // Mostrar el resultado
            MessageBox.Show($"the Perimeter for Triangle is: {PerimeterTriangle}");
        }

        private void Bsquare_Click(object sender, EventArgs e)
        {
            double side1 = double.Parse(sidetxt.Text);

            Square side = new Square(side1);


            double PerimeterSquare = side.perimeter1();

            // Mostrar el resultado
            MessageBox.Show($"the Perimeter for Square is: {PerimeterSquare}");

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void sidetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}