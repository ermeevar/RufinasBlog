using System.ComponentModel.DataAnnotations;

namespace RufinasBlog.Library.Enums
{
    internal enum TagType
    {
        [Display(Name = "New article")]
        New = 1,

        [Display(Name = "Study blog")]
        Study = 1,

        [Display(Name = "Cooking blog")]
        Cook = 1,
        
        [Display(Name = "The blog contains experiments")]
        Experiment = 1,
    }
}
