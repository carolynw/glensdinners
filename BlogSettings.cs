namespace miniblog
{
    public class BlogSettings
    {
        public string Name { get; set; } = "glensdinners";
        public string Description { get; set; } = "Dinner's I've enjoyed";
        public string Owner { get; set; } = "Glen Warburton";
        public int PostsPerPage { get; set; } = 2;
        public int CommentsCloseAfterDays { get; set; } = 10;
    }
}
