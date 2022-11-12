
using System;

namespace _9_Testing
{
    public class Circle
    {
        public Circle(float x, float y, float r)
        {
            center_y = y;
            center_x = x;
            radius = r;
        }
        public float center_x;
        public float center_y;
        public float radius;
        public bool PointIsIn(float x, float y)
        {
            return (Math.Sqrt(Math.Pow(center_x - x, 2) + Math.Pow(center_y - y, 2)) < radius);
        }
        public bool CircleOverlaps(Circle c)
        {
            double distanceBetweenCenters = Math.Sqrt(Math.Pow(c.center_x - center_x,2) + Math.Pow(c.center_y - center_y, 2));
            return (distanceBetweenCenters < radius + c.radius);
        }
    }
}
