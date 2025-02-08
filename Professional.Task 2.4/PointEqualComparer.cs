using System.Diagnostics.CodeAnalysis;
using System.Drawing;

namespace Professional.Task_2._4
{
    internal class PointEqualComparer : IEqualityComparer<Point>
    {
        public bool Equals(Point a, Point b)
        {
            return a.X == b.X && b.Y == a.Y; 
        }

        public int GetHashCode([DisallowNull] Point obj)
        {
            return obj.X .GetHashCode() ^ obj.Y.GetHashCode();
        }
    }
}
