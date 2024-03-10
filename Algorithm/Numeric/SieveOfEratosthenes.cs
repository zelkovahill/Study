public static class SieveOfEratosthenes
{
    public static List<int> GeneratePrimesUpTo(int x)
    {

        List<int> primesList = new List<int>();

        if (x < 2)
        {
            return primesList;
        }

        for (int i = 2; i <= x; i++)
        {
            primesList.Add(i);
        }

        int removeMultiplesOf;

        for (int i = 2; i <= Math.Sqrt(x); i++)
        {
            if (primesList.Contains(i))
            {
                removeMultiplesOf = i;
                for (int j = removeMultiplesOf*removeMultiplesOf; j <= x; j += removeMultiplesOf)
                {
                    primesList.Remove(j);
                }
            }
        }

        return primesList;
    }

}
