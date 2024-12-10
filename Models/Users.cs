namespace Models
{
    public class Users
    {
        public string Company_Id { get; set; } = string.Empty;
        public Companies Companies { get; set; }
    }
}
