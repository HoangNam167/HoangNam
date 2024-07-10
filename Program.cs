using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001207167_NguyenHoangNam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int index = LinearSearch(numbers, 5);
            Console.WriteLine("The number 5 is at index " + index);
        }

        static int LinearSearch(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
