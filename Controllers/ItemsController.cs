using ECommerceAppBackend.Models;
using ECommerceAppBackend.Repositories.Items;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAppBackend.Controllers
{
    [ApiController]
    [Route("Items/")]
    public class ItemsController(IItemsRepository itemsRepository) : Controller
    {
        private readonly IItemsRepository _itemsRepository = itemsRepository;

        [HttpGet("GetAllItems")]
        public IActionResult GetAllItems()
        {
            var items = _itemsRepository.GetItems();
            return Ok(items);
        }

        [HttpGet("OrderItemsAlphabetic")]
        public IActionResult GetItemsAlphabetic()
        {
            var itemsAlphabetic = _itemsRepository.OrderItemsAlphabetic();
            return Ok(itemsAlphabetic);
        }

        [HttpPost("AddNewItem")]
        public IActionResult AddNewItem(ItemModel item)
        {
            _itemsRepository.SaveItemModel(item);
            return Ok();
        }

        [HttpPost("UpdateItem")]
        public IActionResult UpdateItem(ItemModel item)
        {
            _itemsRepository.UpdateItemModel(item);
            return Ok();
        }
    }
}