namespace JuanProject.Models
{
    public class Comment
    {
        public int Id{ get; set; }
        public string Message{ get; set; }
        public DateTime CretedDate{ get; set; } 
        public string AppUserId{ get; set; } 
        public AppUser AppUser{ get; set; } 
        public string BlogId { get; set; }
        public Blog Blog  { get; set; }
    }
}
