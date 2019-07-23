using System;

namespace Chapter7Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Chapter7Program");

            Point point = new Point();
            string mypt = point.ToString();
            Console.WriteLine(mypt);

            Point p2 = new Point();
            mypt = p2.ToString();
            Console.WriteLine(mypt);

            //get the distance between the two points
            double d = point.Distance(p2);
            Console.WriteLine($"The distance between p1 and p2 is {d}");

            //this creates a circle
            Circle circle = new Circle();
            string des = circle.ToString();
            Console.WriteLine(des);
            double area = circle.GetArea();
            double circum = circle.GetCircum();
            Console.WriteLine($"The area is {area} and circum is {circum}");

        }
    }
}

//***************************************************************
using System;

namespace Chapter7Objects
{
    class Point
    {
        int x;
        int y;

        public Point()
        {
            Console.WriteLine("Creating a point:");
            this.x = getParam("Please enter the X coordinate: ");
            this.y = getParam("Please enter the Y coordinate: ");
        }

        private int getParam(string v)
        {
            Console.Write(v);
            int p = int.Parse(Console.ReadLine());
            return p;
        }

        public override string ToString()
        {
            return $"Point: X={this.x}, Y={this.y}";
        }

        public double Distance(Point pt)
        {
            double inner = Math.Pow(this.x - pt.x, 2) + Math.Pow(this.y - pt.y, 2); 
            double distance = Math.Sqrt(inner);
            return distance;
        }
    }
}

//*********************************************************
using System;

namespace Chapter7Objects
{
    class Circle
    {
        Point center;
        int radius;

        public Circle()
        {
            Console.WriteLine("Creating a circle");
            this.center = getCenter("Please enter a point for center: ");
            this.radius = getRad("Please enter the radius: ");
        }

        public override string ToString()
        {
            return $"Circle: center=[{this.center}], radius={this.radius}";
        }

        private int getRad(string prompt)
        {
            Console.Write(prompt);
            int r = int.Parse(Console.ReadLine());
            return r;
        }

        private Point getCenter(string v)
        {
            Console.Write(v);
            Point c = new Point();
            return c;
        }
        
        public double GetArea()
        {
            double a = Math.PI * Math.Pow(this.radius, 2);
            return a;
        }

        public double GetCircum()
        {
            double c = 2 * Math.PI * this.radius;
            return c;
        }
    }

}
