using System.Collections.Generic;

public class SearchParams
{
    public string YearFrom { get; set; }
    public string YearTo { get; set; }
    public string Category { get; set; }

    // Metoda za preverjanje veljavnosti parametrov
    public bool AreParamsValid()
    {
        if (string.IsNullOrEmpty(YearFrom) || string.IsNullOrEmpty(YearTo) || string.IsNullOrEmpty(Category))
        {
            return false;
        }

        if (!int.TryParse(YearFrom, out _) || !int.TryParse(YearTo, out _))
        {
            return false;
        }

        return true;
    }

    // Metoda za pridobivanje angleškega imena kategorije
    public string GetEnglishCategory(Dictionary<string, string> categoryMap)
    {
        if (categoryMap.TryGetValue(Category, out string englishCategory))
        {
            return englishCategory;
        }

        return null;
    }
}
