namespace DevCard_MVC.Models
{
    public class IndexModel
    {
        public List<Project> projects { get; set; }
        public List<Article> articles { get; private set; }
    }
}
