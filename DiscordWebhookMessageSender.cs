using System;
using System.Net;
using System.IO;

namespace SendMessageToDiscord
{
    class Program
    {
        static void Main(string[] args)
        {
            // Replace webhook url with your own
            string webhookurl = "WEBHOOK_URL_GOES_HERE";

            // Replace with your own message
            string message = "Hello, this is a message sent from C# code!";

            // Create a web request to the Discord webhook url
            HttpWebRequest request = WebRequest.Create(webhookurl) as HttpWebRequest;

            // Set the request method, content type and the content length
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = message.Length;

            // Write the request body
            using (StreamWriter writer = new StreamWriter(request.GetRequestStream()))
            {
                writer.Write(message);
            }

            // Get the response and print it
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string result = null;
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                result = reader.ReadToEnd();
            }

            Console.WriteLine(result);
        }
    }
}