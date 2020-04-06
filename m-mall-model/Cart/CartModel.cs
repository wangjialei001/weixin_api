using m_mall_model.Goods;
using m_mall_model.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace m_mall_model.Cart
{
    public class CartModel:ModelBase
    {
        public GoodsModel Goods { get; set; }
        public int Total { get; set; } = 1;
        public decimal Amount { get; set; }
        public decimal TotalAmount { get; set; }
        public UserModel User { get; set; }
    }
}
