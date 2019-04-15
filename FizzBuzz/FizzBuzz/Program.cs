using System;


public static class FizzBuzz
{
    public static void Main()
    {
        String hold_display = "";

        for (int i = 1; i < 101; i++)
        {
            if (!Convert.ToBoolean(i % 3) && !Convert.ToBoolean(i % 5))
            {
                Console.Out.WriteLine("FizzBuzz");
            }
            else if (!Convert.ToBoolean(i % 3))
            {
                Console.Out.WriteLine("Fizz");
            }
            else if (!Convert.ToBoolean(i % 5))
            {
                Console.Out.WriteLine("Buzz");
            }
            else
            {
                Console.Out.WriteLine(i);
            }
        }
               
        while (hold_display != "Q")
        {
            Console.Out.Write("Enter Q to quit.");
            hold_display = Console.ReadLine();
        }
    }
}