using System;

class URI
{
    static void Main(string[] args) 
    {
        string t = GetValidText();
        string tweet = CheckTweetLength(t);
        Console.WriteLine(tweet);
    }

    static string GetValidText()
    {
        string text;

        do
            text = Console.ReadLine();
        while (text.Length > 500);

        return text;
    }

    static string CheckTweetLength(string text)
    {
        if (text.Length <= 140)
            return "TWEET";
        else
            return "MUTE";
    }
}