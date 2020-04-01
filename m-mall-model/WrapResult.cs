using System;
using System.Collections.Generic;
using System.Text;

namespace m_mall_model
{
    public class WrapResult<T>
    {
        public WrapResult()
        {
            meta = new Meta { Code = 0, Message = string.Empty };
        }
        public Meta meta { get; set; }
        public T Data { get; set; }
    }
    public class Meta
    {
        public int Code { get; set; }
        public string Message { get; set; }
    }
}
