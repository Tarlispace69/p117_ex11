using System;

namespace p117_ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int i = 0, input = 0;

            for (i=0; i <= 50; i++)
            {
                //recieving input number
                Console.WriteLine("Enter a 3 digit number:");
                input = int.Parse(Console.ReadLine());

                //checking if digits are different
                if (input % 10 != (input / 10) % 10 && input % 10 != (input / 100) && (input / 10) % 10 != (input / 100))
                {
                    Console.WriteLine(input);
                }
            }
        }
    }
}
