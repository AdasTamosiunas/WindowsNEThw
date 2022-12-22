using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiClient
{
    public class ApiHelper
    {
        //uzklausos i base addresa
        private static readonly HttpClient ApiClient = new HttpClient();
        private static readonly string baseAddress = "https://dog.ceo/api/";


        //gauti visus breeds
        public static async Task<BreedsResponse> GetDogsAsync()
        {
            string s = await ApiClient.GetStringAsync(baseAddress + "breeds/list/all");
            var response = JsonConvert.DeserializeObject<BreedsResponse>(s); //json string i objekta
            return response;
        }

        //subreeds kiekvienam breed
        public static async Task<SubBreedsResponse> GetSubBreedsAsync(string breedname)
        {
            string s = await ApiClient.GetStringAsync(baseAddress + "breed/" + breedname + "/list");
            var response = JsonConvert.DeserializeObject<SubBreedsResponse>(s);
            return response;
        }

        //nuotraukos kiekvienam breed
        public static async Task<ImageResponse> GetBreedImageAsync(string breedname)
        {
            string s = await ApiClient.GetStringAsync(baseAddress + "breed/" + breedname + "/images/random");
            var response = JsonConvert.DeserializeObject<ImageResponse>(s);
            return response;
        }
        //random nuotrauka
        public static async Task<ImageResponse> GetRandomImageAsync()
        {
            string s = await ApiClient.GetStringAsync(baseAddress + "breeds/image/random");
            var response = JsonConvert.DeserializeObject<ImageResponse>(s);
            return response;
        }
    }


    //klases 
    public class BreedsResponse
    {
        public Dictionary<string, string[]> Message { get; set; }
        public string Status { get; set; }
    }

    public class SubBreedsResponse
    {
        public string[] Message { get; set; }
        public string Status { get; set; }
    }

    public class ImageResponse
    {
        public string Message { get; set; }
        public string Status { get; set; }
    }
}
