using System;
using System.Threading.Tasks;
using ApiClient;

namespace ApiClientExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //  visu breeds listas
            var breedsResponse = await ApiHelper.GetDogsAsync();
            Console.WriteLine("Breeds:");
            foreach (var breed in breedsResponse.Message) 
            {
                Console.WriteLine($"{breed.Key}"); 
            }

            // Subreed pasirinktam breed
            Console.WriteLine("\nSubbreeds for poodle:");
            var subBreedsResponse = await ApiHelper.GetSubBreedsAsync("poodle");
            foreach (var subBreed in subBreedsResponse.Message)
            {
                Console.WriteLine(subBreed);
            }

            // Random nuotrauka pasirinktam breed
            Console.WriteLine("\nRandom image of a poodle:");
            var breedImageResponse = await ApiHelper.GetBreedImageAsync("poodle");
            Console.WriteLine(breedImageResponse.Message);

            // Random nuotrauka
            Console.WriteLine("\nRandom image of any breed:");
            var randomImageResponse = await ApiHelper.GetRandomImageAsync();
            Console.WriteLine(randomImageResponse.Message);
        }
    }
}
