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

        [JsonPropertyName("MG")]
        public mg theMg { get; set; }

         [JsonPropertyName("VITB12")]
        public vitb12 theVitb12 { get; set; }

         [JsonPropertyName("VITD")]
        public vitd theVitd { get; set; }

         [JsonPropertyName("SUGAR")]
        public sugar theSugar { get; set; }

        [JsonPropertyName("ZN")]
        public zn theZn { get; set; }

        [JsonPropertyName("CA")]
        public ca theCa { get; set; }

        

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

    public class mg
    {
        [JsonPropertyName("quantity")]
        public double theMgQuan { get; set; }
    }

    public class vitb12
    {
        [JsonPropertyName("quantity")]
        public double theVitb12Quan { get; set; }
    }

    public class vitd
    {
        [JsonPropertyName("quantity")]
        public double theVitdQuan { get; set; }
    }

    public class sugar
    {
        [JsonPropertyName("quantity")]
        public double theSugarQuan { get; set; }
    }
public class zn
    {
        [JsonPropertyName("quantity")]
        public double theZnQuan { get; set; }
    }

public class ca
    {
        [JsonPropertyName("quantity")]
        public double theCaQuan { get; set; }
    }
}
