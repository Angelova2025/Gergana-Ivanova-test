
namespace _9_klass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int theBigest = 0;
            int sum = 0;
            int element = 0; 

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0;i < nums.Length; i++)
            {
                if (nums[i] > theBigest)
                {
                 theBigest = nums[i];
                }
                sum += nums[i];
            }
          
        }
    }
}
