/*The Equals method in C# is used to determine whether two objects are 
 * considered equal. By default, the Equals method in the base Object 
 * class checks for reference equality, meaning it returns true 
 * only if both objects point to the same memory location. 
 * However, in many cases, you want to define equality based on the 
 * values of the object's properties
 * rather than its reference.*/


namespace Day6_09_Why_should_we_override_toEqual
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Point p)
            {
                return X == p.X && Y == p.Y;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (X, Y).GetHashCode();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var point1 = new Point { X = 1, Y = 2 };
            var point2 = new Point { X = 1, Y = 2 };
            var point3 = new Point { X = 2, Y = 3 };

            Console.WriteLine(point1.Equals(point2)); // Output: True
            Console.WriteLine(point1.Equals(point3)); // Output: False
        }
    }

}
