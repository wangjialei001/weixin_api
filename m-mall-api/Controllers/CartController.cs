using m_mall_core.Cart;
using m_mall_core.Goods;
using m_mall_model;
using m_mall_model.Cart;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace m_mall_api.Controllers
{
    [Route("api/cart")]
    public class CartController : Controller
    {
        private readonly IGoodService goodService;
        private readonly ICartService cartService;
        public CartController(IGoodService goodService, ICartService cartService)
        {
            this.goodService = goodService;
            this.cartService = cartService;
        }
        [HttpPost]
        public async Task<WrapResult<object>> Post(CartPostModel input)
        {
            cartService.AddToCart(input);
            return await Task.FromResult(new WrapResult<object> { });
        }
        [HttpGet]
        public async Task<WrapResult<object>> Get()
        {
            var data = cartService.GetCart(1);
            var result = new WrapResult<object> { Data = new { Items = data } };
            return await Task.FromResult(result);
        }
    }
}
