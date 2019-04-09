using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main(string[] args)
    {
        Console.Clear();
        string pattern = @"^[\s]*(.*?)[\s]*$";
        string input = @"test
  avoid starting spaces
avoid ending spaces  
 avoid starting and ending spaces ";
        RegexOptions options = RegexOptions.Multiline;
        
        foreach (Match m in Regex.Matches(input, pattern, options))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
    }
}