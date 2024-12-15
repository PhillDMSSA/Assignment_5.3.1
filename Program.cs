using System.Xml;

namespace Assignment_5._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] flowerbed1 = { 1, 0, 0, 0, 0, 0, 1 };
            int[] flowerbed2 = { 1, 0, 0, 1, 0, 0, 1 };

            int n = 2;
            bool plant1 = PlottingSeed(flowerbed1, n);
            bool plant2 = PlottingSeed(flowerbed2, n);

            Console.WriteLine("Example 1:");
             Console.WriteLine($"Output: {plant1}");
            
            Console.WriteLine();
            Console.WriteLine("Example 2:");
             Console.WriteLine($"Output: {plant2}");
            

        }
    


        static bool PlottingSeed(int[] fB, int n)
        {
            int count = 0;
            // bool canPlant = false;

            for (int i = 0; i < fB.Length; i++)
            {
                if (fB[i] == 0 &&
                    (i == 0 || fB[i - 1] == 0) &&
                    (i == fB.Length - 1 || fB[i + 1] == 0))
                {
                    fB[i] = 1;
                    count++;

                    if (count >= n)
                    {
                        return true;
                    }
                }
                
            }
            return count >= n;

        }
       public static string PrintArray(int[] array)
        {
            return string.Join(",", array); 
        }


    }
}
