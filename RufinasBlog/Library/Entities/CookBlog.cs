using RufinasBlog.Library.Abstracts;
using RufinasBlog.Library.Enums;
using System.Collections.Generic;

namespace RufinasBlog.Library.Entities
{
    /// <summary>
    /// Blog for cooking
    /// </summary>
    internal class CookBlog : Blog, ILiked, IShared
    {
        public Dictionary<string, string> Ingrediens { get; set; }

        //public string Share()
        //{
        //    return "Выбранный вами рецепт отправлен";
        //}

        public int MaxLikes => 970;

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

        public int AddLike(int likes)
        {
            return likes += 3;
        }
    }
}
