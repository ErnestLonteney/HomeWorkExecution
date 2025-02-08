using System.Collections.Specialized;

namespace Professional.Task_2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var points = new OrderedDictionary<Point, string>(new PointEqualComparer());

            var pointA = new Point(2, 4);
            var pointB = new Point(2, 4);

            points[pointA] = "Point A";
            points[pointB] = "Point B";

            Console.WriteLine(points.Count());
        }
    }
}
