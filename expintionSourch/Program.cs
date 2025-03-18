using System;

namespace exponentialSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            int num = int.Parse(Console.ReadLine());

            if (arr[0] == num)
            {
                Console.WriteLine("Elementin indeksi: 0");
                return;
            }

            int index = 1;
            exponential(arr, num, index);
        }

        static void exponential(int[] arr, int num, int index)
        {

            while (index < arr.Length && arr[index] <= num)
            {
                if (arr[index] == num)
                {
                    Console.WriteLine($"Elementin indeksi: {index}");
                    return;
                }
                index *= 2;
            }

            int left = index / 2;
            int right = index;
            if (right > arr.Length - 1)
            {
                right = arr.Length - 1;
            }
            int result = Result(arr, num, left, right);
            if (result == -1)
            {
                Console.WriteLine("Element tapılmadı.");
            }
            else
            {
                Console.WriteLine($"Elementin indeksi: {result}");
            }
        }

        static int Result(int[] arr, int num, int left, int right)
        {
            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == num)
                {
                    return mid;
                }
                else if (arr[mid] > num)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
    }
}
