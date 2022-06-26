using System;

namespace SortingAlgorythems
{
    class Program
    {
        public static void Main()
        {
            var selectionSort = new SelectionSort();
            var bubbleSort = new BubbleSort();

            selectionSort.Execution();
            bubbleSort.Execution();
        }
    }
}
