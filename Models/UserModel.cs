using System.ComponentModel.DataAnnotations;


namespace ECommerceAppBackend.Models;

public class UserModel
{
    public int Id { get; set; }
    [Required] public required string Name { get; set; }
    [Required] [EmailAddress] public required string Email { get; set; }
    [Required] public required string Password { get; set; }
    public bool EmailConfirmed { get; set; } = false;
    public ShopCartModel? Cart { get; set; }
    public List<ShopCartModel>? CartHistoryList { get; set; }
    public string? UserRole { get; set; }
}