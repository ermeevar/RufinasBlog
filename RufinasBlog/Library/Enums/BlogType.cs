using System.ComponentModel.DataAnnotations;

namespace RufinasBlog.Library.Enums
{
    internal enum BlogType
    {
        [Display(Name = "Cooking blog")]
        Cook = 1,

        [Display(Name = "Universe blog")]
        Study = 2
    }
}
