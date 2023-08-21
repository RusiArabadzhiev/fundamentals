namespace currentoddnumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            int i = 0;
            bool hasenoughnumbers = true;

            while (hasenoughnumbers)
            {

                int currentodnumber = 1 + (i * 2);
                sum += currentodnumber;
                i++;
                Console.WriteLine($"{currentodnumber}");


                if (i == number) { 
                
                    hasenoughnumbers=false;
                }

                

            }


        }
    }
}