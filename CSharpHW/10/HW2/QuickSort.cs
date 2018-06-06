namespace HW2
{
    class QuickSort
    {
        public static void QuickSortArray(double[] elements, int left, int right)
        {
            var i = left; 
            var j = right;

            var pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                var swapElement = elements[i];

                if (i <= j)
                {
                    // Swap
                    elements[i] = elements[j];
                    elements[j] = swapElement;
                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                QuickSortArray(elements, left, j);
            }

            if (i < right)
            {
                QuickSortArray(elements, i, right);
            }
        }
    }
}
