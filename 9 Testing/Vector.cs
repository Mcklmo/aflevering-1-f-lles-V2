namespace _9_Testing
{
    public class Vector
    {
        public double X, Y;
        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }
        public (double,double) Get()
        {
            return (X, Y);
        }
        public void Subtract(Vector v)
        {
            X -= v.X;
            Y -= v.Y;
        }
        public void Add(Vector v)
        {
            X += v.X;
            Y += v.Y;
        }
        public void Scalar(double scalar)
        {
            X *= scalar;
            Y *= scalar;
        }
        public double CrossProduct(Vector v)
        {
            return (X * v.Y) - (Y * v.X);
        }
    }
}
