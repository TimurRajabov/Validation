using System.ComponentModel.DataAnnotations;


namespace Validation.Models
{
    public class UserModel
    {
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; }
        public byte[]? Age { get; set; }
        public Adress? UserAdress { get; set; }

    }
}


public class Adress
{
    public string City { get; set; }
    public string Country { get; set; }
    public int ZipCode { get; set; }
    public string? Street { get; set; }
    public string Region { get; set; }
}