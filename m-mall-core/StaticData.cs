using m_mall_model.Goods;
using System;
using System.Collections.Generic;
using System.Text;

namespace m_mall_core
{
    public class StaticData
    {
        static StaticData()
        {
            CartUserGoods = new Dictionary<int, List<GoodsModel>> { };
        }
        public static Dictionary<int, List<GoodsModel>> CartUserGoods { get; set; }
    }
}
