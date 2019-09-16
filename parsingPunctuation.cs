using System;
using System.Globalization;

public class Example
{
   public static void Main()
   {
        char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

        string text = "one\ttwo three:four,five six seven";
        System.Console.WriteLine($"Original text: '{text}'");

        string[] words = text.Split(delimiterChars);//gets ride of characters in delimiterchars when parsing
        System.Console.WriteLine($"{words.Length} words in text:");

        foreach (var word in words)
        {
            System.Console.WriteLine($"<{word}>");//parses sentence into individual words
        }

    }
}

/* output Original text: 'one	two three:four,five six seven'
7 words in text:
<one>
<two>
<three>
<four>
<five>
<six>
<seven>*/
