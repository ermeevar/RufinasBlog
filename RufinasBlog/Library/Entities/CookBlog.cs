using RufinasBlog.Library.Abstracts;
using RufinasBlog.Library.Enums;
using System.Collections.Generic;

namespace RufinasBlog.Library.Entities
{
    /// <summary>
    /// Blog for cooking
    /// </summary>
    internal class CookBlog : Blog // В конце всегда ставим наименование родительского класса
    {
        public Dictionary<string, string> Ingrediens { get; set; }

        public CookBlog(string title, BlogType type, 
            Dictionary<string, string> ingrediens, List<TagType>? tags = null) 
            : base(title, type, tags)
        {
            this.Ingrediens = ingrediens;
        }

        public override string GetShortBlog()
        {
            return $"{this.Title.ToUpper()}\n" + 
                $"{GetIngredientsString()}\n" +
                $"{Body}";
        }

        private string GetIngredientsString()
        {
            string ingredientsString = "Ингридиенты:\n";

            foreach (var ingridient in Ingrediens)
                ingredientsString += $"{ingridient.Key} - {ingridient.Value}\n";

            return ingredientsString;
        }
    }
}
