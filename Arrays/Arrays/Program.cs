namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Arrays
             * 
             */

            int[] nums = { 1, 2, 3, 4, 5};
            Console.WriteLine(nums[0]);
            Console.WriteLine(nums[1]);
            Console.WriteLine(nums[2]);
            Console.WriteLine(nums[3]);
            Console.WriteLine(nums[4]);

            nums[3] = 100;
            Console.WriteLine(nums[3]);

            int[] nums2 = new int[3];
            nums2[0] = 10; 
            nums2[1]=20;
            nums2[2] = 30;
            Console.WriteLine(nums2[0]);
            Console.WriteLine(nums2[1]);
            Console.WriteLine(nums2[2]);

            Console.WriteLine("Max Value : "+nums2.Max());
            Console.WriteLine("Average : " + nums2.Average());



            string[] names = { "apple","orange"};
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);

            // Multi Dimensional Array
            int[,] nums3 = new int[2, 2] { {100,200 }, {300,400 } };
            Console.WriteLine(nums3[0,0]);
            Console.WriteLine(nums3[0,1]);
            Console.WriteLine(nums3[1,0]);
            Console.WriteLine(nums3[1,1]);
            Console.WriteLine(nums3.Length);

        }
    }
}
