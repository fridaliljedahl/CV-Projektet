namespace MessageWebAPI.Models
{
    public class HomeViewModel
    {
        public IEnumerable<User> AllUsers { get; set; }
        public IEnumerable<User> NonPrivateUsers { get; set; }
        public IEnumerable<Project> Projects { get; set; }
    }
}
