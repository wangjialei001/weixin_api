using m_mall_model.Cart;
using m_mall_model.Goods;
using System;
using System.Collections.Generic;
using System.Text;

namespace m_mall_core.Cart
{
    public interface ICartService
    {
        void AddToCart(CartPostModel input);
        List<GetCartModel> GetCart(int userId);
    }
}
