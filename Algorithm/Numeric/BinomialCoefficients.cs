public static class BinomialCoefficients
{
    
    public static ulong Calculate(uint n, uint k)
    {
        ulong result = 1;

        if (k > n - k)
            k = n - k;
        

        for (int i = 0; i < k; ++i)
        {
            result *= Convert.ToUInt64(n - i);
            result /= Convert.ToUInt64(i + 1);
        }

        return result;
    }
}