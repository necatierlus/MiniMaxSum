using System.Collections.Generic;
using System.Linq;
using System;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        long max = arr[0];
        for (int i = 0; i < arr.Count; i++)
            if (arr[i] > max)
                max = arr[i];//biggest element

        long min = arr[0];
        for (int i = 0; i < arr.Count; i++)
            if (arr[i] < min)
                min = arr[i]; //smallest element

        long biggest = 0, smallest = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            smallest = smallest + arr[i];
            biggest = biggest + arr[i];
        }

        smallest -= min;
        biggest -= max;

        Console.WriteLine(biggest + " " + smallest);

    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
