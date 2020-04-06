using System;
using System.Collections.Generic;
using System.Text;

namespace m_mall_model.Banner
{
    public class BannerModel
    {
        public string Title { get; set; }
        public string Remark { get; set; }
        public int Sort { get; set; }
        public bool Is_Show { get; set; }
        public List<ImageBase> Images { get; set; }
        public DateTime Create_At { get; set; } = DateTime.Now;
        public DateTime Update_At { get; set; }
    }
}
