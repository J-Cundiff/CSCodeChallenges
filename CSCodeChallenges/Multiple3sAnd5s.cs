namespace CSCodeChallenges
{
    internal class Multiple3sAnd5s
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Code Challenge 1:Sum of Multiple 3s or 5s\n\n");

            int sum = 0;

            for (int i = 1; i < 1000; i++)

            {
                if (i % 3 == 0 || i % 5 == 0)

                    sum += i;
            }
            Console.WriteLine($"The sum of all multiples of 3 or 5 is: {sum}");
        }
    }
}