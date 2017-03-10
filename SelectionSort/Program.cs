using System;
using System.Linq;

namespace SelectionSort
{
    class Program
    {
        static void Main()
        {
            int[] numsToSort = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int temp;

            if (numsToSort.Length > 1)
            {
                for (int i = 0; i < numsToSort.Length - 1; i++)
                {
                    for (int j = i + 1; j < numsToSort.Length; j++)
                    {
                        if (numsToSort[i] > numsToSort[j])
                        {
                            temp = numsToSort[i];
                            numsToSort[i] = numsToSort[j];
                            numsToSort[j] = temp;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(", ", numsToSort));
        }
    }
}
