using System;
using System.Net.Http;
using System.Text;

namespace HelloWorldAPITest
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            string url =
            "https://sandbox.api.service.nhs.uk/hello-world/hello/world";

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseString = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseString);
            Console.ReadLine();
        }
    }
}