using System;

namespace calcular_el_perimetro_de_una_figura
{
    public interface IPerimeterCalculable
    {
        double perimeter1();
    }
    //base class
    public abstract class Perimeter : IPerimeterCalculable
    {
        public abstract double perimeter1();
    }

    internal class Triangle : Perimeter
    {
        protected double side1;
        protected double side2;
        protected double side3;

        public double Side1
        {
            get { return side1; }
            set { side1 = value; }

        }
        public double Side2
        {
            get { return side2; }
            set { side2 = value; }

        }
        public double Side3
        {
            get { return side3; }
            set { side3 = value; }
        }


        public Triangle(double S1, double S2, double S3)
        {
            side1 = S1;
            side2 = S2;
            side3 = S3;
        }

        public override double perimeter1()
        {
            return side1 + side2 + side3;


        }
    }

    public class Square : Perimeter
    {
        private double side;

        public double Sidequare
        {
            get { return side; }
            set { side = value; }

        }
        public Square(double S)
        {
            Sidequare = S;
        }

        // Implementation of the method to calculate the perimeter of the square
        public override double perimeter1()
        {
            return 4 * side;
        }
    }

    public class Circle : Perimeter
    {
        public double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Circle(double r1)
        {
            radius = r1;
        }

        public override double perimeter1()
        {
            return 2 * Math.PI * radius;
        }
    }

}