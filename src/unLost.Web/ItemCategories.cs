using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace unLost.Web
{
    public class ItemCategories
    {
        public Dictionary<int, string> CategoryDictionary { get; set; }
        public Dictionary<int, Dictionary <int, string>> SubcatDictionaryDictionary { get; set; }

        public ItemCategories()
        {
            CategoryDictionary = new Dictionary<int, string>()
            {
                { 0, "n/a" },
                { 1, "Sports Kit" },
                { 2, "School Uniform" },
                { 3, "Coats" },
                { 4, "Stationary" },
                { 5, "Other" }
            };

            SubcatDictionaryDictionary = new Dictionary<int, Dictionary<int, string>>()
            {
                { 0, new Dictionary<int, string>() { { 0, "n/a" } } },
                { 1, new Dictionary<int, string>() { { 1, "Shorts"}, { 2, "Trousers"}, { 3, "Shoes"}, { 4, "Tops"}, { 5, "Outerware"}, { 6, "Equipment"}, { 7, "Other" } } },
                { 2, new Dictionary<int, string>() { { 1, "Blazers" }, { 2, "Shirts" }, { 3, "Trousers" }, { 4, "Shoes" }, { 5, "Other" } } },
                { 3, new Dictionary<int, string>() { { 0, "n/a"} } },
                { 4, new Dictionary<int, string>() { { 0, "n/a"} } }
            };
        }
    }
}
