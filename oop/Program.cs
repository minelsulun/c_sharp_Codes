using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek_sekiller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Square square = new Square();
            Triangle triangle = new Triangle(3,4);

            Sphere sphere = new Sphere();
            Cube cube = new Cube();
            Tetrahedron tetrahedron = new Tetrahedron();

            circle.R = 6;
            circle.toString();
            Console.WriteLine($"area={circle.getArea()}\n");

            square.Edge = 6;
            square.toString();
            Console.WriteLine($"area={square.getArea()}\n");

            triangle.toString();
            Console.WriteLine($"area={triangle.getArea()}\n\n");

            sphere.R = 6;
            sphere.toString();
            Console.WriteLine($"area={sphere.getArea()} volume={sphere.getVolume()}\n");

            cube.Edge = 6;
            cube.toString();
            Console.WriteLine($"area={cube.getArea()}  volume={cube.getVolume()}\n");

            tetrahedron.T = 6;
            tetrahedron.toString();
            Console.WriteLine($"area={tetrahedron.getArea()}  volume={tetrahedron.getVolume()}\n");


            Console.ReadLine();
        }
    }
}


abstract class Shape
{
    public abstract void toString();
    public abstract decimal getArea();
}

class TwoDimensionalShape : Shape
{
    public override void toString() { }
    public override decimal getArea() { return 0; }
}

    class Circle: TwoDimensionalShape
    {
        private decimal r;
        public decimal R
        {

            get { return r; }

            set
            {
                if (value < 0)
                {
                    throw new Exception("r cannot be negative");
                }
                r = value;
            }
        }
        public override decimal getArea()
        {
            return (decimal)Math.PI * r * r;
        }

    public override void toString()
        {
            Console.WriteLine("its a circle ");
        }
    }
    class Square : TwoDimensionalShape
    {
        private decimal edge;
        public decimal Edge
        {
            get { return edge; }
            set
            {
                if (edge < 0)
                {
                    throw new Exception("edge cannot be negative");
                }
                edge = value;
            }
        }
        
        public override void toString()
            {
                Console.WriteLine("its a square ");
            }
        public override decimal getArea()
        {
            return edge*edge;
        }
    }
    class Triangle : TwoDimensionalShape
    {
        private decimal baseLength;
        private decimal height;
    //constructor method
    public Triangle(decimal baseLength, decimal height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }
        public override decimal getArea()
        {
             
            return baseLength * height * (decimal)(0.5); ;
        }

        public override void toString()
        {
            Console.WriteLine("its a triangle ");
        }
    }
class ThreeDimensionalShape : Shape
{
    public override void toString() { }
    public virtual decimal getVolume()
    {
        return 0;
    }
    public override decimal getArea() { return 0; }
}

    class Sphere: ThreeDimensionalShape
    {
        private decimal r;
        public decimal R {  
        
            get { return r; }
    
            set 
            { 
            if (value<0) 
                {
                    throw new Exception("r cannot be negative");
                }
            r = value;
            }
        }  
        public override void toString()
        {
            Console.WriteLine("its a Sphere ");
        }
        public override decimal getVolume()
        {
            return (4/3) * (decimal)Math.PI * r * r * r;
        }
    public override decimal getArea()
    {
        return 4 * (decimal)Math.PI * r * r;
    }
}
    class Cube : ThreeDimensionalShape
    {
        private decimal edge;
        public decimal Edge { 
            get { return edge; } 
            set
            {
            if (edge < 0)
            {
                throw new Exception("edge cannot be negative");
            }
            edge = value;
            }
        }
        public override void toString()
        {
            Console.WriteLine("its a cube ");
        }
    public override decimal getVolume()
    {
        return edge*edge*edge;
    }
    public override decimal getArea()
    {
        return 6 * edge * edge;
    }

}
    class Tetrahedron : ThreeDimensionalShape
    {
        
    private decimal t;
    public decimal T
        {
        get { return t; }
        set { 
            if (t < 0) 
            { throw new Exception("t cannot be negative");} 
            t = value;}
        }        
        public override void toString()
        {
            Console.WriteLine("its a tetrahedron ");
        }
        public override decimal getVolume()
        {
        return (t * t * t) / (6 * (decimal)Math.Sqrt(2));
    }

    public override decimal getArea()
    {
        return (decimal)Math.Sqrt(3) * t * t;
    }

}
