using System.Net.Http.Json;
using NutriApp.Model;

namespace NutriApp.Clients;
public class NutritionClient{

    private readonly HttpClient _client;
    
    //constructor
    public NutritionClient(HttpClient Client){
        _client = Client;
        _client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "22a1959633mshead70d5aae391f6p1402a8jsnaaad21c933b1");
         _client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "edamam-edamam-nutrition-analysis.p.rapidapi.com");
    }

    

    public async Task<NutritionDetails> GetNutri(string a){

        string url = "https://edamam-edamam-nutrition-analysis.p.rapidapi.com/api/nutrition-data?ingr=" + "1%20large%20apple";
        if(a != null){
            url = "https://edamam-edamam-nutrition-analysis.p.rapidapi.com/api/nutrition-data?ingr="+ a;
        }        
        return await _client.GetFromJsonAsync<NutritionDetails>(url);
    }

}