using m_mall_model;
using m_mall_model.Banner;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace m_mall_api.Controllers
{
    [Route("api/banner")]
    public class BannerController : Controller
    {
        [HttpGet]
        public async Task<WrapResult<object>> Get(bool is_show = true)
        {
            var data = new List<BannerModel> {
                new BannerModel{
                    Title="图片1",
                    Remark="图片1-remark",
                    Sort=1,
                    Is_Show=true,
                    Images=new List<ImageBase>{ new ImageBase{Path= "http://localhost:5000/images/1.png" } }
                },
                new BannerModel{
                    Title="图片2",
                    Remark="图片2-remark",
                    Sort=2,
                    Is_Show=true,
                    Images=new List<ImageBase>{ new ImageBase{Path= "http://localhost:5000/images/1.png" } }
                },
                new BannerModel{
                    Title="图片3",
                    Remark="图片3-remark",
                    Sort=3,
                    Is_Show=true,
                    Images=new List<ImageBase>{ new ImageBase{Path= "http://localhost:5000/images/1.png" } }
                }
            };
            var result = new WrapResult<object> { Data = new { Items = data } };
            return await Task.FromResult(result);
        }
    }
}
