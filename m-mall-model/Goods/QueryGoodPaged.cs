using System;
using System.Collections.Generic;
using System.Text;

namespace m_mall_model.Goods
{
    public class QueryGoodPaged: PagedQueryBase
    {
        public int Type { get; set; }
    }
}
