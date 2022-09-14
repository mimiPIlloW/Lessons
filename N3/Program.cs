using System.Data;

namespace N3
{
    class N3
    {
        static void Main(string[] args) 
        {
            int sum = 0;
            int comp = 1;
            int[] nums = new int[3];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
                
                    sum += nums[i];
                    comp *= nums[i];
            }
            Console.WriteLine("sum {0}",sum);
            Console.WriteLine("comp {0}",comp);
        }
    }
}