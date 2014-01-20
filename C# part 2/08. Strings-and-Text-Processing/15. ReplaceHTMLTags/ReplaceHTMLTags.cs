/*
 * Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]. 
 */

using System;
using System.Text;
using System.Collections.Generic;

class ReplaceHTMLTags
{
    static void Main()
    {
        string html = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";

        string oldOpenTag = "<a href=\"";
        string oldCloseTag = "</a>";
        string newOpenTag = "[URL=";
        string newCloseTag = "[/URL]";

        //indexes of the '>' chars from the old opening tags
        List<int> indexes = new List<int>();
        int index = -1;
        while ((index = html.IndexOf(oldOpenTag, index + 1)) > 0)
        {
            indexes.Add(html.IndexOf("\">", index + 1));
        }

        StringBuilder builder = new StringBuilder(html);

        for (int i = indexes.Count - 1; i >= 0; i--)
        {
            builder.Replace("\">", "]", indexes[i], 2);
        }

        builder.Replace(oldOpenTag, newOpenTag);
        builder.Replace(oldCloseTag, newCloseTag);

        Console.WriteLine(builder);

    }
}