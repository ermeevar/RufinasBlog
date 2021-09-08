namespace RufinasBlog.Library.Abstracts
{
    /// <summary>
    /// Liked objects
    /// </summary>
    interface ILiked
    {
        int MaxLikes { get; }

        int AddLike(int likes);
    }
}
