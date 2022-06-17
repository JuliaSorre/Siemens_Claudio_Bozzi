using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;

namespace apiresponse
{
    class Program
    {
        static async Task Main(string[] args)
        {
            /*
             API:
            https://www.wtv676.siemens-info.com/ev16444144/api/.well-known/knx/
             */

            HttpClient client = new HttpClient();

            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                var response = await client.GetAsync("https://www.wtv676.siemens-info.com/ev16444144/api/.well-known/knx/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();


                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }

        }
    }
}
