using System;
using System.Numerics;

public class ArraySum
{
    public static void Main()
    {
        String hold_display = "";
        String posString = "2559733455000111890001001346798";
        String posString2 = "10000000000000000000000000";
        String negString = "-900001255555532000000000000";
        BigInteger sum = 0;
        BigInteger num1 = 0;
        BigInteger num2 = 0;
        BigInteger num3 = 0;
        num1 = BigInteger.Parse(posString);
        num2 = BigInteger.Parse(posString2);
        num3 = BigInteger.Parse(negString);


        BigInteger[] num_array = { num1, num2, num3 };
        foreach (BigInteger item in num_array)
        {
            sum += item;
        }
        Console.Out.WriteLine("The sum is: {0}", sum);
        while (hold_display != "Q")
        {
            Console.Out.Write("Enter Q to quit.");
            hold_display = Console.ReadLine();
        }
    }
}