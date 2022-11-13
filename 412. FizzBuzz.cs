namespace LeetCode_Solutions;

public class LeetCode
{
    // https://leetcode.com/problems/fizz-buzz/description/
    public static string[] FizzBuzz(int n)
    {
        var answerInt = new int[n];
        var answerString = new string[n];
        for (var i = 1; i <= answerInt.Length; i++)
        {
            answerInt[i - 1] = i;
            if ((answerInt[i - 1] % 5) == 0 & (answerInt[i - 1] % 3) == 0)
                answerString[i - 1] = "FizzBuzz";
            else if ((answerInt[i - 1] % 5) == 0)
                answerString[i - 1] = "Buzz";
            else if ((answerInt[i - 1] % 3) == 0)
                answerString[i - 1] = "Fizz";
            else
                answerString[i - 1] = i.ToString();
        }
        
        return answerString;
    }


    private static void Main()
    {
        string[] answer = FizzBuzz(15);
        foreach (var t in answer) Console.Write($"{t}, ");
    }
}