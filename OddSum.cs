using System;

public class OddSum
{
	public static int Main(int[] num_array)
	{
        sum = 0;
        foreach i in num_array {
            if !(i % 2) {
                sum += i;
            }
        }
        return sum;   
	}
}


