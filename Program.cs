namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[30];
            Random random = new Random();
            int minValue = 1;
            int maxValue = 10;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minValue, maxValue);
                Console.Write(numbers[i] + ",");
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                int temporaryVariable = 0;

                for (int j = 0; j < numbers.Length - 1; j++)
                {

                    if (numbers[j] > numbers[j + 1])
                    {
                        temporaryVariable = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temporaryVariable;
                    }

                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(" " + numbers[i] + ",");
            }
        }
    }
}