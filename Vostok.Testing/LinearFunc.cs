namespace Vostok.Testing
{
    public class LinearFunc
    {
        public readonly double B;
        public readonly double K;

        public LinearFunc(double b, double k)
        {
            B = b;
            K = k;
        }

        public double GetValue(double x)
        {
            return K * x + B;
        }
    }
}