using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine(MissingNumber(new int[] { 0, 1})); 
    }

    static string MissingNumber(int[] nums)
    {
        List<int> missingList = new List<int>();
        int minNum = nums.Min(); // 1

        for (int i = minNum; i <= nums.Length + minNum; i++)
        {
            if (!nums.Contains(i))
            {
                missingList.Add(i);
            }
        }

        return  string.Join("",  missingList) ;
    }
}
