namespace Models
{
    public class User
    {
        public string Company_Id { get; set; } = string.Empty;
        public Company Companies { get; set; }
    }
}
