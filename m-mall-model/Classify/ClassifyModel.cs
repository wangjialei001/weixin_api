using System;
using System.Collections.Generic;
using System.Text;

namespace m_mall_model.Classify
{
    public class ClassifyModel
    {
        public string Name { get; set; }
        public string Remark { get; set; }
        public DateTime Create_At { get; set; } = DateTime.Now;
        public DateTime Update_At { get; set; }
    }
}
