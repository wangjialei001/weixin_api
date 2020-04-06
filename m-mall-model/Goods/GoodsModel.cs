using m_mall_model.Classify;
using System;
using System.Collections.Generic;
using System.Text;

namespace m_mall_model.Goods
{
    public class GoodsModel: ModelBase
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Remark { get; set; }
        public List<ImageBase> Images { get; set; }
        public List<ClassifyModel> Types { get; set; }
    }
}
