using System;

namespace ExCh10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = { 1, 4, 6, 8, 3 };
            //Array.ForEach(j, Console.Write);
            //Console.WriteLine();
            Console.WriteLine(Sum(testArray));
            Console.WriteLine(Avg(testArray));
            Console.WriteLine(Max(testArray));
            /*Array.ForEach(ReverseArray(testArray), Console.Write);
            Console.WriteLine();*/
            Reverse(testArray);
            Console.WriteLine();
            /*Array.ForEach(RotateArray(testArray, 2), Console.Write);
            Console.WriteLine();*/
            Rotate(testArray, 2);
            Console.WriteLine();
            /*Array.ForEach(SortArray(testArray), Console.Write);
            Console.WriteLine();*/
            Sort(testArray);
        }

        public static int Sum(int[] z)
        {
            int s = 0;
            for (int i = 0; i < z.Length; i++)
            {
                s = s + z[i];
            }
            return s;
        }


        public static double Avg(int[] nums)
        {
            int x = 0;
            foreach (int num in nums)
            {
                x += num;
            }
            return x / nums.Length;
        }

        public static int Max(int[] nums)
        {
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (max < nums[i])
                {
                    max = nums[i];
                }
            }
            return max;
        }

        public static int[] ReverseArray(int[] nums) // This method outputs a reversed array, it's just for practice
        {                                            // NOT the void method in the question
            int[] rnums = new int[nums.Length];
            int x = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                rnums[x] = nums[i];
                x++;
            }
            return rnums;
        }

        public static void Reverse(int[] nums)
        {
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                Console.Write($"{nums[i]} ");
            }
        }

        public static int[] RotateArray(int[] nums, int places)  //This method outputs a left-rotated array and is for practice
        {                                                        //Not the void method in the question
            int[] rnums = new int[nums.Length];
            for (int i = 0; i < nums.Length - places; i++)
            {
                rnums[i] = nums[i + places];
            }
            int z = 0;
            for (int i = nums.Length - places; i < nums.Length; i++)
            {
                rnums[i] = nums[z];
                z++;
            }
            return rnums;
        }

        public static void Rotate(int[] nums, int places)
        {
            for (int i = 0; i < nums.Length - places; i++)
            {
                Console.Write($"{nums[i + places]} ");
            }
            int z = 0;
            for (int i = nums.Length - places; i < nums.Length; i++)
            {
                Console.Write($"{nums[z]} ");
                z++;
            }
        }

        public static int[] SortArray(int[] nums)  //This method outputs a left-rotated array and is for practice
        {                                          //Not the void method in the question
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        int x = nums[i];
                        nums[i] = nums[j];
                        nums[j] = x;
                    }
                }
            }
            return nums;
        }
        public static void Sort(int[] nums)
        { 
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        int x = nums[i];
                        nums[i] = nums[j];
                        nums[j] = x;
                    }
                }
                Console.Write($"{nums[i]} ");
            }
            Console.Write(nums[^1]);
        }
    }
}
