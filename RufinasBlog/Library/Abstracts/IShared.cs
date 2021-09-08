namespace RufinasBlog.Library.Abstracts
{
    /// <summary>
    /// Shared objects
    /// </summary>
    interface IShared
    {
        private static int SharingCount { get; set; } = 7;

        string Share()
        {
            SharingCount++;
            return $"Данный объект отправлен {SharingCount} раз";
        }
    }
}
