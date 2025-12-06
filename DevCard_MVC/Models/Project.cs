namespace DevCard_MVC.Models
{
    public class Project
    {
        public Project(int id,string name,string description,string image, string client)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
            Client = client;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Client { get; set; }


    }

}
