/*
 * Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and 
 * stores it the current directory. Find in Google how to download files in C#. Be sure to catch all exceptions 
 * and to free any used resources in the finally block.
 */

using System;
using System.Net;

class DownloadFileFromURL
{
    static void Main()
    {
        WebClient webClient = new WebClient();
        try
        {
            string url = "http://www.devbg.org/img/Logo-BASD.jpg";
            webClient.DownloadFile(@url, "Logo-BASD.jpg");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("URL address must not be empty.");
        }
        catch (WebException)
        {
            Console.WriteLine("Network problem - unreachable recource or no network connection found.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The method type is not supporte.");
        }
        finally
        {
            webClient.Dispose();
        }
    }
}