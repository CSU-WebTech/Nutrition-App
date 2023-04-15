using System.Text.Json.Serialization;

namespace NutriApp.Model
{
    public class NutritionDetails
    {
        [JsonPropertyName("calories")]
        public int calories { get; set; }
        [JsonPropertyName("glycemicIndex")]
        public int glycemicIndex { get; set; }

        [JsonPropertyName("totalWeight")]
        public int totalWeight { get; set; }
    }

}
