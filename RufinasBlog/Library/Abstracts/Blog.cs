using RufinasBlog.Library.Enums;
using System;
using System.Collections.Generic;

namespace RufinasBlog.Library.Abstracts
{
    /// <summary>
    /// Main blog
    /// </summary>
    internal abstract class Blog
    {
        #region Properties
        protected BlogType Type { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public List<TagType> Tags { get; set; }
            = new List<TagType>() { TagType.New };
        #endregion

        public Blog(string title, BlogType type, List<TagType> tags = null)
        {
            this.Title = title;
            this.Type = type;
            if (tags != null)
                this.Tags.AddRange(tags);
        }

        public abstract string GetShortBlog();

        public override string ToString()
        {
            return $"Тип блога - {this.GetType()}\n" +
                $"Заголовок - {this.Title}\n" +
                $"Тип блога - {this.Type}";
        }
    }
}
