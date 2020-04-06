using System;
using System.Collections.Generic;
using System.Text;

namespace m_mall_model
{
    public class PagedQueryBase
    {
        public int Page { get; set; }
        public int Limit { get; set; }
    }
}
