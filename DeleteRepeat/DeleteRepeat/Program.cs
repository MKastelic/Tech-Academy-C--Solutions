using System;


public static class DeleteRepeat
{
    public static void Main()
    {
        String hold_display = "";
        var some_string = "Mississippi";

        string DeleteRepeat(string source)
        {
            var no_repeatStr = "";

            foreach (char item in source)
            {
                var itemStr = item.ToString();
                itemStr = itemStr.ToLower();

                if (!no_repeatStr.ToLower().Contains(itemStr))
                {
                    no_repeatStr += item;
                }
            }
            return no_repeatStr;
        }

        var finalStr = DeleteRepeat(some_string);

        Console.Out.WriteLine("The original string is: {0} ", some_string);
        Console.Out.WriteLine("The string with no repeated letters is: {0} ", finalStr);
        while (hold_display != "Q")
        {
            Console.Out.Write("Enter Q to quit.");
            hold_display = Console.ReadLine();
        }
    }
}
