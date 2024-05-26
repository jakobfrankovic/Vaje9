using System.Collections.Generic;

namespace DataBaseVmesnik
{
    public class SearchParams
    {
        // Lastnosti za iskanje
        public string YearFrom { get; set; }
        public string YearTo { get; set; }
        public string Category { get; set; }

        // Funkcija za preverjanje, ali so vnesene letnice veljavne
        public bool AreYearsValid()
        {
            return int.TryParse(YearFrom, out _) && int.TryParse(YearTo, out _);
        }

        // Funkcija za preverjanje, ali so vneseni podatki veljavni
        public bool AreParamsValid()
        {
            return AreYearsValid() && !string.IsNullOrWhiteSpace(Category);
        }

        // Funkcija za pridobitev angleške kategorije
        public string GetEnglishCategory(Dictionary<string, string> categoryMap)
        {
            return categoryMap.ContainsKey(Category) ? categoryMap[Category] : null;
        }
    }
}
