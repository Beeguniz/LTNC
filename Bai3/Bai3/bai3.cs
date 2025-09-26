using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

class TextProcessor
{
    private string text;
    public TextProcessor(string input)
    {
        text = input;
    }

    public void XoaKhoangTrangThua()
    {
        while (text.Contains("  "))
        {
            text = text.Replace("  ", " ");
        }
        text = text.Trim();
    }

    public void InHoaCacChuCaiDau()
    {
        if(string.IsNullOrEmpty(text)) return;

        char[] chars = text.ToCharArray();
        bool capitalizeNext = true;

        for (int i = 0; i < chars.Length; i++)
        {
            char c = chars[i];

            if (capitalizeNext)
            {
                if (char.IsLetter(c))
                {
                    chars[i] = char.ToUpper(c);
                    capitalizeNext = false;
                }
                else
                {
                    capitalizeNext = true;
                }
            }
            if (c == '.' || c == '!' || c == '?')
            {
                capitalizeNext = true;
            }
        }
        text = new string(chars);
    }
    
    public string ProcessText()
    {
        XoaKhoangTrangThua();
        InHoaCacChuCaiDau();
        return text;
    }

    public void ThongKeVanBan()
    {
        string lower = text.ToLower();

        List<string> words = new List<string>();
        string currentWord = "";

        for (int i = 0; i < lower.Length; i++)
        {
            char c = lower[i];
            if (char.IsLetter(c))
            {
                currentWord += c;
            }
            else
            {
                if (currentWord.Length > 0)
                {
                    words.Add(currentWord);
                    currentWord = "";
                }
            }    
        }
        if (currentWord.Length > 0)
        {
            words.Add(currentWord);
        }

        int totalWords = words.Count;
        var wordFrequency = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (wordFrequency.ContainsKey(word))
            {
                wordFrequency[word]++;
            }
            else
            {
                wordFrequency[word] = 1;
            }
        }
        int distinctWords = wordFrequency.Count;

        Console.WriteLine($"Tong so tu: {totalWords}");
        Console.WriteLine($"So tu khac nhau: {distinctWords}");
        Console.WriteLine("Tan suat xuat hien cua moi tu:");

        foreach (var kvp in wordFrequency)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Nhap van ban: ");
        string input = Console.ReadLine();

        var p = new TextProcessor(input);
        Console.WriteLine("Doan van sau chinh sua:");
        Console.WriteLine(p.ProcessText());
        p.ThongKeVanBan();
    }
}