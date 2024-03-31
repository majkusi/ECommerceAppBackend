namespace ECommerceAppBackend.Models;

public class ItemModel
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public  required double Price { get; set; }
    public required int InStock { get; set; }
    public int? Discount { get; set; }
    public required string SerialNumber { get; set; }
    public  ItemProducerModel? Producer { get; set; }
    public  ItemTypeModel? ItemType { get; set; }
}