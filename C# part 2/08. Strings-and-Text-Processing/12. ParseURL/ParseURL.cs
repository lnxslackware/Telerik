/*
 * Write a program that parses an URL address and 
 * extracts from it the [protocol], [server] and [resource] elements. 
 * For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
 * [protocol] = "http"
 * [server] = "www.devbg.org"
 * [resource] = "/forum/index.php"
 */

using System;

class ParseURL
{
    static void Main()
    {
        string url = "http://www.devbg.org/forum/index.php";
        int previousElementindex = -1;
        int nextElementIndex = -1;

        previousElementindex = url.IndexOf(":");
        string protocol = url.Substring(0, previousElementindex);

        previousElementindex = url.IndexOf("//", previousElementindex + 1);
        nextElementIndex = url.IndexOf("/", previousElementindex + 2);
        string server = url.Substring(previousElementindex + 2, nextElementIndex - previousElementindex - 2);

        string resource = url.Substring(nextElementIndex, url.Length - nextElementIndex);

        Console.WriteLine("[protocol] = {0}", protocol);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}", resource);
    }
}