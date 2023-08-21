namespace division
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int dividor = 0;


            if (number % 10 == 0)
            {
                dividor = 10;
            }
            else if (number % 7 == 0)
            {
                dividor = 7;
            }
            else if (number % 6 == 0)
            {
                dividor =6;

            }
            else if (number % 3 == 0)
            {
                dividor = 3;

            }
            else if (number % 2 == 0)
            {
                dividor = 2;

            }
            else {

                Console.WriteLine("not divisible");
            }

            Console.WriteLine($"is divisible by {dividor}");
        }
    }
}