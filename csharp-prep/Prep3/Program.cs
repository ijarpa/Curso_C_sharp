using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Console.Write("Please enter the magic number from 1 to 100: ");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("lower");
            }
            else
            {
                Console.WriteLine($"got it! the numer is {magicNumber}");
            }
        }
    }
}