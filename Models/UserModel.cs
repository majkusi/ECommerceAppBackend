namespace ECommerceAppBackend.Models;

public class UserModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public bool EmailConfirmed { get; set; } = false;
    public ShopCartModel? Cart { get; set; }
    public List<ShopCartModel>? CartHistoryList { get; set; }

}