using System;
using System.Globalization;

public class Example
{
   public static void Main()
   {

        string phrase = "The quick brown fox jumps over the lazy dog.";
        string[] words = phrase.Split(' ');

        foreach (var word in words)
        {
            System.Console.WriteLine($"<{word}>");
        }
    }

}
//splits the sentence into individual words in an array
