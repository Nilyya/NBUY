using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Entity.Concrete;
using ShoppingApp.Entity.Concrete.Identity;
using ShoppingApp.Web.Models.Dtos;

namespace ShoppingApp.Web.Controllers
{
    [Authorize]
    public class CardController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly ICardService _cardManager;
        private readonly ICardItemService _cardItemManager;
        private readonly IOrderService _orderManager;

        public CardController(UserManager<User> userManager, ICardService cardManager, ICardItemService cardItemManager, IOrderService orderManager)
        {
            _userManager = userManager;
            _cardManager = cardManager;
            _cardItemManager = cardItemManager;
            _orderManager = orderManager;
        }

        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);
            var card = await _cardManager.GetCardByUserIdAsync(userId);

            var cardDto = new CardDto
            {
                CardId = card.Id,
                CardItems = card.CardItems.Select(ci => new CardItemDto
                {
                    CardItemId = ci.Id,
                    ProductId = ci.ProductId,
                    ProductName = ci.Product.Name,
                    ItemPrice = ci.Product.Price,
                    ImageUrl = ci.Product.ImageUrl,
                    Quantity = ci.Quantity,
                    ProductUrl = ci.Product.Url
                }).ToList()
            };
            return View(cardDto);
        }

        [HttpPost]
        public async Task<IActionResult> AddToCard(int productId, int quantity)
        {
            var userId = _userManager.GetUserId(User);
            await _cardManager.AddToCard(userId, productId, quantity);
            return RedirectToAction("Index", "Card");
        }

        [HttpPost]
        public async Task<IActionResult> ChangeQuantity(int cardItemId, int quantity)
        {
            await _cardItemManager.ChangeQuantity(cardItemId, quantity);
            return RedirectToAction("Index", "Card");
        }
        public async Task<IActionResult> DeleteFromCard(int id)
        {
            var cardItem=await _cardItemManager.GetByIdAsync(id);
            _cardItemManager.Delete(cardItem);
            return RedirectToAction("Index", "Card");
        }
        public async Task<IActionResult> Checkout()
        {
            var userId=_userManager.GetUserId(User);
            var user=await _userManager.FindByIdAsync(userId);
            var card=await _cardManager.GetCardByUserIdAsync(userId);
            OrderDto orderDto = new OrderDto
            {
                FirstName=user.FirstName,
                LastName=user.LastName,
                Address=user.Address,
                City=user.City,
                Phone=user.PhoneNumber,
                Email=user.Email,
                CardDto = new CardDto
                {
                    CardId = card.Id,
                    CardItems = card.CardItems.Select(ci => new CardItemDto
                    {
                        CardItemId = ci.Id,
                        ProductId = ci.ProductId,
                        ProductName = ci.Product.Name,
                        ItemPrice = ci.Product.Price,
                        ImageUrl = ci.Product.ImageUrl,
                        ProductUrl = ci.Product.Url,
                        Quantity = ci.Quantity
                    }).ToList()
                }
            };
             return View(orderDto);

        }
        [HttpPost]
        public async Task<IActionResult> Checkout(OrderDto orderDto)
        {
            if (ModelState.IsValid)
            {
                var userId =  _userManager.GetUserId(User);
                var card = await _cardManager.GetCardByUserIdAsync(userId);
                orderDto.CardDto = new CardDto
                {
                    CardId=card.Id,
                    CardItems=card.CardItems.Select(ci=>new CardItemDto
                    { 
                    CardItemId = ci.Id,
                    ProductId = ci.ProductId,
                    ProductName = ci.Product.Name,
                    ItemPrice = ci.Product.Price,
                    ImageUrl = ci.Product.ImageUrl,
                    ProductUrl = ci.Product.Url,
                    Quantity = ci.Quantity
                    }).ToList()
                };
                //Ödeme iþlemlerini yapacaðýz
                //Yapýlan satýþý kaydetme iþlemlri(Save Order)
                SaveOrder(orderDto,userId);
            }
            return View("Index","Home");
        }
        private async void SaveOrder(OrderDto orderDto,string userId)
        {
            Order order = new Order();            
            order.OrderNumber ="SA-" + new Random().Next(111111111, 999999999).ToString();
            order.OrderState = EnumOrderState.Unpaid;//Bu geçici aslýnda ödeme tamamlanmýþ olacak
            order.OrderType = EnumOrderType.CreditCard;
            order.OrderDate = new DateTime();
            order.FirsName = orderDto.FirstName;
            order.LastName=orderDto.LastName;
            order.Email=orderDto.Email;
            order.Phone= orderDto.Phone;
            order.City= orderDto.City;
            order.Address=orderDto.Address;
            order.UserId=userId;
            order.OrderItems = new List<OrderItem>();
            foreach (var item in orderDto.CardDto.CardItems)
            {
                var orderItem = new OrderItem();
                orderItem.Price = item.ItemPrice;
                orderItem.Quantity = item.Quantity;
                orderItem.ProductId=item.ProductId;
                order.OrderItems.Add(orderItem);
            }
           await 
        }
    }
}