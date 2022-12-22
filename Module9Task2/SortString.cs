namespace Module9Task2
{
    public static class SortString
    {
        /// Сортировка массива строк

        public static void Sort(string[] lastname, TypeSort typeSort)
        {
            for (int i = 0; i < lastname.Length; i++)
            {
                for (int j = 0; j < lastname.Length - 1; j++)
                {
                    switch (typeSort)
                    {
                        case TypeSort.Down:
                            if (isMax(lastname[j], lastname[j + 1]))
                                (lastname[j], lastname[j + 1]) = (lastname[j + 1], lastname[j]);
                            break;
                        case TypeSort.Up:
                            if (isMin(lastname[j], lastname[j + 1]))
                                (lastname[j], lastname[j + 1]) = (lastname[j + 1], lastname[j]);
                            break;
                    }
                }
            }
        }


        /// Сравнение строк если a > b

        static bool isMax(string a, string b)
        {
            var count = 0;
            if (a.Length > b.Length) count = b.Length;
            else count = a.Length;

            for (int i = 0; i < count; i++)
            {
                if (a[i] > b[i]) return true;
                else if (a[i] < b[i]) return false;
            }
            return true;
        }


        /// Сравнение строк если a < b

        static bool isMin(string a, string b)
        {
            var count = 0;
            if (a.Length > b.Length) count = b.Length;
            else count = a.Length;

            for (int i = 0; i < count; i++)
            {
                if (a[i] < b[i]) return true;
                else if (a[i] > b[i]) return false;
            }
            return true;
        }

        /// Тип сортировки
        public enum TypeSort
        {
            Up,
            Down
        }
    }
}