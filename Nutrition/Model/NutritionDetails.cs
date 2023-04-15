using System.Text.Json.Serialization;

namespace Nutrition.Model
{
    public class NutritionDetails
    {
        [JsonPropertyName("calories")]
        public int calories { get; set; }
        [JsonPropertyName("glycemicIndex")]
        public int glycemicIndex { get; set; }

        [JsonPropertyName("totalWeight")]
        public double totalWeight { get; set; }
    }

}
