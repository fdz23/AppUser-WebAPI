namespace AppUser.Domain
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string CellPhone { get; set; }
        public string Password { get; set; }
        public string CodeRFID { get; set; }
        public string Token { get; set; }
    }
}