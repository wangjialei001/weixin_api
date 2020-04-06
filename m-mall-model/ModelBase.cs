using System;
using System.Collections.Generic;
using System.Text;

namespace m_mall_model
{
    public class ModelBase
    {
        public DateTime Create_At { get; set; } = DateTime.Now;
        public DateTime Update_At { get; set; }
        public int _id { get; set; }
    }
}
