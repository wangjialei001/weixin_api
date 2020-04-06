using m_mall_model;
using m_mall_model.Classify;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace m_mall_api.Controllers
{
    [Route("api/classify")]
    public class ClassifyController : Controller
    {
        [HttpGet]
        public async Task<WrapResult<object>> Get(int page, int limit)
        {
            var data = new WrapResult<object>
            {
                Data = new
                {
                    Items =new List<ClassifyModel> {
                        new ClassifyModel { Remark="谷物类",Name="谷物类",_id=1},
                        new ClassifyModel { Remark="糯米类",Name="糯米类",_id=2},
                        new ClassifyModel { Remark="五谷杂粮类",Name="五谷杂粮类",_id=3},
                        new ClassifyModel { Remark="东北大米",Name="东北大米",_id=4}
                    },
                    Paginate=0,
                    Number=10
                }
            };
            return data;
        }
    }
}
