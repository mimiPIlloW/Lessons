using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubleSort
{
    class Buble
    {
        static void Main(string[] args)
        {
            int[] nums = { 123, 24, 5, 12, 45, 6 };
            for (int i = 0; i < nums.Length - 1; i++)
                for (int j = 0; j < nums.Length - 1; j++)
                    if (nums[j] < nums[j + 1]) {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
            foreach (int a in nums) {
                Console.Write(" {0}", a);  
            }

        }
    }
}
