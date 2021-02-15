using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace FireBaseClientConsoleApp
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            // 1° use postman to Obtain a valid token
            //  see https://blog-bertrand-thomas.devpro.fr/2019/10/24/api-authentication-with-asp-net-core-3-0-and-firebase/
            //
            //  POST to get a valid token...
            // a) https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key=[API_KEY]
            //{
            //    "email": "myemail@address.changeme",
            //    "password": "mysecretpassword",
            //    "returnSecureToken": "true"
            //}

            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + "eyJhbGciOiJSUzI1NiIsImtpZCI6IjYxMDgzMDRiYWRmNDc1MWIyMWUwNDQwNTQyMDZhNDFkOGZmMWNiYTgiLCJ0eXAiOiJKV1QifQ.eyJpc3MiOiJodHRwczovL3NlY3VyZXRva2VuLmdvb2dsZS5jb20vZmlyLWNvb2tib29rLWExNzg3IiwiYXVkIjoiZmlyLWNvb2tib29rLWExNzg3IiwiYXV0aF90aW1lIjoxNjEzMzgzODkwLCJ1c2VyX2lkIjoiakozamlQV1lESGRTb3ZZaFR6eVBIUXBva3lqMSIsInN1YiI6ImpKM2ppUFdZREhkU292WWhUenlQSFFwb2t5ajEiLCJpYXQiOjE2MTMzODM4OTAsImV4cCI6MTYxMzM4NzQ5MCwiZW1haWwiOiJ2aW5jZW50LnRlbmVAZ21haWwuY29tIiwiZW1haWxfdmVyaWZpZWQiOmZhbHNlLCJmaXJlYmFzZSI6eyJpZGVudGl0aWVzIjp7ImVtYWlsIjpbInZpbmNlbnQudGVuZUBnbWFpbC5jb20iXX0sInNpZ25faW5fcHJvdmlkZXIiOiJwYXNzd29yZCJ9fQ.hYYGJ9BjL6QVrpQGtO8pREvK4hu2v8wQ8gE9ryEEUAMiPL-LRq3NYmOR1jUAtgC_aUFkJVihEkFo9sgdKWGi-0YAQGChm4gUk_49TM8AcK2evaNy7KAqCuitmffS0j2iw5kLjraBRtJGwcBOXb5VSgruDJj9IC0kdPCRJEUUeueIR9IfNwfJvkTNKyq91UpwITfJLqtQEEnAdlDkojw86ovhZ67ki7uxm_UOuCvNz5GT1h4app0AbL9-vcWasVqvT7s7bJFr3nMpYOxipBo2OECXkZORyyX_qNU1NxpTI0OSYiePECP08pO-Uxe4phcWEfDJ12ZCddcj8hLPSvfk3g");
            var result = await client.GetAsync("https://localhost:5001/api/weatherforecast");
            if(result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = await result.Content.ReadAsStringAsync();
                var jsonContent = JsonConvert.DeserializeObject<List<WeatherForecastDto>>(content);
                Console.WriteLine(content);
            }

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
