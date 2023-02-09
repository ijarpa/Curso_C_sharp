using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //Initialize variable max with the first number in numbers list
        int max = numbers[0];

        //Iterate through each number in numbers list
        foreach (int number in numbers)
        {
            //Check if number is greater than max
            if (number > max)
            {
                //Set max to number
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}