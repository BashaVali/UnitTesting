using System;
namespace FindMaximumNumber
{
    public class FindMaximumNum
    {
        public int FindMaxInteger(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            }
            else
                return c;
        }
    }
}