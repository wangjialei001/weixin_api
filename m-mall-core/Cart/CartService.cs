using m_mall_model;
using m_mall_model.Cart;
using m_mall_model.Classify;
using m_mall_model.Goods;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace m_mall_core.Cart
{
    public class CartService : ICartService
    {
        //private readonly IHttpContextAccessor httpContext;
        //public CartService(IHttpContextAccessor httpContext)
        //{
        //    //this.httpContext = httpContext;
        //}
        public List<GetCartModel> GetCart(int userId)
        {
            List<GoodsModel> data;
            StaticData.CartUserGoods.TryGetValue(userId, out data);
            var result = new List<GetCartModel> { };
            if(StaticData.CartUserGoods.TryGetValue(userId, out data))
            {
                foreach (var d in data)
                {
                    result.Add(new GetCartModel { Goods = d });
                }
            }
            return result;
        }
        public void AddToCart(CartPostModel input)
        {
           // var user = httpContext.HttpContext.User;
            //var claims = user.Claims;
            var data = new GoodsModel
            {
                _id = 1,
                Name = "鲜享黑米",
                Price = 10,
                Remark = "鲜享黑米，不好吃不要钱！",
                Images = new List<ImageBase>{
                        new ImageBase {
                            Path = "http://a0.att.hudong.com/78/52/01200000123847134434529793168.jpg" } },
                Types = new List<ClassifyModel>{
                                new ClassifyModel{
                                     Remark="谷物类",Name="谷物类",_id=1
                                }
                            }
            };
            StaticData.CartUserGoods.TryAdd(1, new List<GoodsModel> {
                data
            });
        }
    }
}
