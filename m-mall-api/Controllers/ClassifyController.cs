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
                    Items =new List<ClassifyModel> { new ClassifyModel { Remark="test",Name="test"} },
                    Paginate=0,
                    Number=10
                }
            };
            return data;
        }
    }
}
