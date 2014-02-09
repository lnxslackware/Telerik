using System;
using System.Text.RegularExpressions;

class GuessTheName
{
    //static bool isName(string[] sentences, string keyword)
    //{
    //    //must test sentence.ToLower()
    //    bool isName = false;
    //    int sentenceIndex = FindContainingSentence(sentences, keyword);
    //    string[] wordsInSentence = sentences[sentenceIndex].Split(new string[] { keyword }, StringSplitOptions.None);
    //    int indexOfKeyword = Array.IndexOf(wordsInSentence, keyword);

    //    //process left part

    //    //process right part

    //    return isName;
    //}

    static bool isPlace(string[] sentences, string keyword)
    {
        bool isPlace = false;

        string[] patterns =
        {
            @"[А-Я][а-я]+ [а-я]+",
            @"[А-Я][а-я]+чна ",
            @"[А-Я][а-я]+чен ",
            @"[А-Я][а-я]+дна ",
            @"[А-Я][а-я]+ден ",
            @"[А-Я][а-я]+ият ",
            @"[А-Я][а-я]+ата ",
            @"[А-Я][а-я]+ска ",
            @"[А-Я][а-я]+жка ",
            @"[А-Я][а-я]+ски ",
            @"[А-Я][а-я]+-[а-я]+"
        };

        foreach (var pattern in patterns)
        {
            isPlace = isPlace || Regex.IsMatch(keyword, pattern);
        }

        if (isPlace == true)
        {
            return isPlace;
        }

        int sentenceIndex = FindContainingSentence(sentences, keyword);
        string[] wordsInSentence = sentences[sentenceIndex].Split(' ');

        int wordIndex = Array.IndexOf(wordsInSentence, keyword.Split(' ')[0]);

        if (wordIndex > 0)
        {

            switch (wordsInSentence[wordIndex - 1].ToLower())
            {
                case "в":
                    return true;
                case "във":
                    return true;
                case "край":
                    return true;
                case "до":
                    return true;
                case "площад":
                    return true;
                case "местност":
                    return true;
                case "град":
                    return true;
                case "село":
                    return true;
                case "махала":
                    return true;
                case "от":
                    return true;
                case "на":
                    return true;
                case "още":
                    return true;
                default:
                    break;
            }
        }

        //check right
        for (int i = wordIndex; i < wordsInSentence.Length; i++)
        {
            //check if containing place predicates
            if (wordsInSentence[i].ToLower() == "където" || wordsInSentence[i].ToLower() == "там")
            {
                return true;
            }
        }

        return isPlace;
    }

    static int FindContainingSentence(string[] sentences, string keyword)
    {
        int index = -1;

        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].IndexOf(keyword) >= 0)
            {
                index = i;
            }
        }

        return index;
    }

    //static bool Place(string keyword)
    //{
    //    bool isPlace = false;
    //    string[] patterns =
    //    {
    //        @"[А-Я][а-я]+ [а-я]+",
    //        @"[А-Я][а-я]+чна ",
    //        @"[А-Я][а-я]+чен ",
    //        @"[А-Я][а-я]+дна ",
    //        @"[А-Я][а-я]+ден ",
    //        @"[А-Я][а-я]+ият ",
    //        @"[А-Я][а-я]+ата ",
    //        @"[А-Я][а-я]+ска ",
    //        @"[А-Я][а-я]+жка ",
    //        @"[А-Я][а-я]+ски ",
    //        @"[А-Я][а-я]+-[а-я]+"
    //    };

    //    foreach (var pattern in patterns)
    //    {
    //        isPlace = isPlace || Regex.IsMatch(keyword, pattern);
    //    }

    //    return isPlace;
    //}

    static bool Person(string keyword)
    {
        bool isPlace = false;
        string[] patterns =
        {
            @"[А-Я][а-я]+ [IVXDLCM]",
            @"[А-Я][а-я]+-[А-Я][а-я]+"
        };

        foreach (var pattern in patterns)
        {
            isPlace = isPlace || Regex.IsMatch(keyword, pattern);
        }

        return isPlace;
    }

    static void Main()
    {
        string[] inputSentences = Console.ReadLine().Split(new string[] { ".", "!", "?" }, StringSplitOptions.RemoveEmptyEntries);
        string[] testNames = new string[int.Parse(Console.ReadLine())];

        for (int i = 0; i < testNames.Length; i++)
        {
            testNames[i] = Console.ReadLine();
        }

        foreach (var name in testNames)
        {
            if (isPlace(inputSentences, name))
            {
                Console.WriteLine("Place");
            }
            else
            {
                Console.WriteLine("Person");
            }
        }
    }
}