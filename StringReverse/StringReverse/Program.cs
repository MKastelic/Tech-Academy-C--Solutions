using System;


public static class StringReverse
{
    public static void Main()
    {
        String hold_display = "";
        var some_string = "!nrael ot nuf si #C";
        
        string Reverse(string source)
        {
            var char_array = source.ToCharArray();
            Array.Reverse(char_array);
            return new string(char_array);
        }

        String reversed_string = Reverse(some_string);

        Console.Out.WriteLine("The original string is: {0} ", some_string);
        Console.Out.WriteLine("The reversed string is: {0} ", reversed_string);
        while (hold_display != "Q")
        {
            Console.Out.Write("Enter Q to quit.");
            hold_display = Console.ReadLine();
        }
    }
}
