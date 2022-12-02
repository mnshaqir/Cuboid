using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuboid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // based on parameter ()
            Cuboid aCuboid = new Cuboid();

            aCuboid.ShowAllProperties();

            aCuboid.height = 10;
            aCuboid.length = 15;
            aCuboid.width = 19;

            aCuboid.ShowAllProperties();

            Cuboid Cuboid2 = new Cuboid(15, 25, 35);
            Cuboid2.ShowAllProperties();
            Console.WriteLine("New parameter", "Height = {0}, Length = {1}, Width = {2}", Cuboid2.height, Cuboid2.length, Cuboid2.width);
            Cuboid2.width = 30;
            Cuboid2.height = 50;
            Cuboid2.length = 10;
            Cuboid2.ShowAllProperties();
            Console.WriteLine("Volume of Cuboid2 = {0}", Cuboid2.Volume());

            Console.ReadKey();

        }
    }
    // Blueprint or Template
    // Class 
    class Cuboid
    {
        // Data
        private double _height;
        private double _length;
        private double _width;

        // interface for data
        public double height {
            get { return _height; } 
            set { _height = value; }
        }

        public double length {
            get { return _length; }
            set { _length = value; }
        }

        public double width {
            get { return _width; }
            set { _width = value; }
        }

        // Default Constructor
        public Cuboid()
        {
            height = 0;
            length = 0;
            width = 0;
        }

        // Constructor the gives each value
        public Cuboid(double _height, double _length, double _width)
        {
            height = _height;
            length = _length;
            width = _width;
        }
        // Method or Function
        public void ShowAllProperties()
        {
            Console.WriteLine("Height = {0}, Length = {1}, Width = {2}", height, length, width);
        }
        // for volume calc.
        public double Volume()
        {
            return _height * _length * _width; 
        }
    }
}
