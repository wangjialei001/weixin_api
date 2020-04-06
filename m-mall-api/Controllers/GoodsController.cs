using m_mall_core.Goods;
using m_mall_model;
using m_mall_model.Classify;
using m_mall_model.Goods;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace m_mall_api.Controllers
{
    [Route("api/goods")]
    public class GoodsController : Controller
    {
        [HttpGet("{id}")]
        public async Task<WrapResult<object>> Get(int id)
        {
            var data = new GoodsModel
            {
                _id = 1,
                Name = "鲜享黑米",
                Price = 10,
                Remark = "鲜享黑米，不好吃不要钱！",
                Images = new List<ImageBase>{
                        new ImageBase {
                            Path = "http://a0.att.hudong.com/78/52/01200000123847134434529793168.jpg" } },
                Types = new List<ClassifyModel>{
                                new ClassifyModel{
                                     Remark="谷物类",Name="谷物类",_id=1
                                }
                            }
            };
            var result = new WrapResult<object>
            {
                Data = data
            };
            return await Task.FromResult(result);
        }
        [HttpGet]
        public async Task<WrapResult<object>> GetList(QueryGoodPaged query)
        {
            var data = new List<GoodsModel>
            {
                new GoodsModel{ _id=1,Name="鲜享黑米", Price=10, Remark="鲜享黑米，不好吃不要钱！",
                    Images=new List<ImageBase>{
                        new ImageBase { 
                            Path = "http://a0.att.hudong.com/78/52/01200000123847134434529793168.jpg" } },
                            Types = new List<ClassifyModel>{
                                new ClassifyModel{
                                     Remark="谷物类",Name="谷物类",_id=1
                                }
                            }
                },
                new GoodsModel{ _id=2,Name="新玉米五谷杂粮", Price=50, Remark="新玉米五谷杂粮，不好吃不要钱！",
                    Images=new List<ImageBase>{ new ImageBase { Path = "http://localhost:5000/images/1.png" } } },
                new GoodsModel{ _id=3,Name="自产红小豆", Price=(decimal)6.66, Remark="自产红小豆，不好吃不要钱！",
                    Images=new List<ImageBase>{ new ImageBase { Path = "http://localhost:5000/images/1.png" } } }
            };
            var result = new WrapResult<object>
            {
                Data = new
                {
                    Items = data,
                    Paginate = new
                    {
                        Total=3,
                        Next = 1,
                        PerPage = 1
                    }
                }
            };
            return await Task.FromResult(result);
        }
    }
}
