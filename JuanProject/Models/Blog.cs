namespace JuanProject.Models
{
    public class Blog
    {
        public int Id{ get; set; }
        public string ImageUrl{ get; set; }
        public DateTime CreateTime{ get; set; }
        public string Desc{ get; set; }
        public string  AuthorName{ get; set; }
        public List<Comment> Comments{ get; set; }
    }
}
