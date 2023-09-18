namespace _1._3Uzduotis_Array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] randomNumbers = { 3, 9, 5, 3, 7 };

            Console.WriteLine(MaxValue(randomNumbers));

        }
        public static int MaxValue(int[] randomNumbers)
        {
            int max = randomNumbers[0];

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                if (randomNumbers[i] > max)
                {
                    max = randomNumbers[i];
                    
                }
            }
            return max;
        }
    }
}