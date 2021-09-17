namespace IsTriangleKata
{
    public class Triangle
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            if ((a + b <= c) || (a + c <= b) || (b + c <= a))
            {
                return false;
            }
            return (a > 0) && (b > 0) && (c > 0);
        }
    }
}