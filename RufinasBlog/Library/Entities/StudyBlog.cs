﻿using RufinasBlog.Library.Abstracts;
using RufinasBlog.Library.Enums;
using System.Collections.Generic;

namespace RufinasBlog.Library.Entities
{
    /// <summary>
    /// Blog about study
    /// </summary>
    internal sealed class StudyBlog : Blog
    {
        public StudyBlog(string title, BlogType type, List<TagType> tags = null)
            : base(title, type, tags)  { }

        public override string GetShortBlog()
        {
            return $"Статья о учебе" +
               $"{this.Title.ToUpper()}\n\n" +
               $"{Body}";
        }

        public new string ToString()
        {
            return "Блог об учебе";
        }
    }
}
