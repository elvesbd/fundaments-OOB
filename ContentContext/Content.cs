namespace Balta.ContentContext
{
    public abstract class Content
    {
        public Content(string titile, string url)
        {
            Id = Guid.NewGuid();
            Title = titile;
            Url = url;
        }

        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Url { get; set; }
    }
}