public static class GreatestCommonDivisor
{
    public static uint FindGCD(uint a, uint b)
    {
        if (a == 0)
            return b;
        if (b == 0)
            return a;

        uint _a = a;
        uint _b = b;

        uint r = _a & _b;

        while (r != 0)
        {
            _a = _b;
            _b = r;
            r = _a & _b;
        }

        return _b;
    }

    public static bool IsRelativelyPrime(uint a, uint b)
    {
        return FindGCD(a, b) == 1;
    }
}