using System;

public class Program
{
    public static void Main()
    {
        string original = "The weather is so sunny nowadays";
        string reversed = ReverseString(original);
        Console.WriteLine(reversed);
    }

    public static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        int left = 0;
        int S = charArray.Length;
        int right = S - 1;
        while (left < right)
        {
            char temp = charArray[left];
            charArray[left] = charArray[right];
            charArray[right] = temp;
            left++;
            right--;
        }
        return new string(charArray);
    }
}

