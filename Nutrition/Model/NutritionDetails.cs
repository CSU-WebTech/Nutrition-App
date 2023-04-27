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

        [JsonPropertyName("totalNutrients")]
        public totalNutrients thetotalNutrients { get; set; }
    }

    public class totalNutrients
    {
        [JsonPropertyName("FAT")]
        public fat theFat { get; set; }

        [JsonPropertyName("PROCNT")]
        public procnt theProcnt { get; set; }

        [JsonPropertyName("CHOCDF")]
        public chocdf theChocdf { get; set; }

        [JsonPropertyName("FE")]
        public fe theFe { get; set; }

    }

    public class fat
    {
        [JsonPropertyName("quantity")]
        public double theFatQuan { get; set; }
    }

    public class procnt
    {
        [JsonPropertyName("quantity")]
        public double theProQuan { get; set; }
    }

    public class chocdf
    {
        [JsonPropertyName("quantity")]
        public double theChocdfQuan { get; set; }
    }

    public class fe
    {
        [JsonPropertyName("quantity")]
        public double theFeQuan { get; set; }
    }

}
