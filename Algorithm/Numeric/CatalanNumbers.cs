public static class CatalanNumbers
    {
        private static Dictionary<uint, ulong> _catalanNumbers = new Dictionary<uint, ulong>() { { 0, 1 }, { 1, 1 } };

        private static ulong _recursiveHelper(uint rank)
        {
            if (_catalanNumbers.ContainsKey(rank))
                return _catalanNumbers[rank];

            ulong number = 0;
            uint lastRank = rank - 1;

            for (uint i = 0; i <= lastRank; ++i)
            {
                ulong firstPart = _recursiveHelper(i);
                ulong secondPart = _recursiveHelper(lastRank - i);

                if (!_catalanNumbers.ContainsKey(i)) _catalanNumbers.Add(i, firstPart);
                if (!_catalanNumbers.ContainsKey(lastRank - i)) _catalanNumbers.Add(lastRank - i, secondPart);

                number = number + (firstPart * secondPart);
            }

            return number;
        }

        public static ulong GetNumber(uint rank)
        {
            Debug.Assert(_catalanNumbers.Count >= 2);

            return _recursiveHelper(rank);
        }

        public static ulong GetNumberByBinomialCoefficients(uint rank)
        {
            var catalanNumber = BinomialCoefficients.Calculate(2 * rank, rank);

            return Convert.ToUInt64(catalanNumber / (rank + 1));
        }

        public static List<ulong> GetRange(uint fromRank, uint toRank)
        {
            List<ulong> numbers = new List<ulong>();

            if (fromRank > toRank)
                return null;

            for (uint i = fromRank; i <= toRank; ++i)
                numbers.Add(GetNumber(i));

            return numbers;
        }

    }