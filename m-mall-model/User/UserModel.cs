using System;
using System.Collections.Generic;
using System.Text;

namespace m_mall_model.User
{
    public class UserModel:ModelBase
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Avatar { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string NickName { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }
        public int LoginAttempts { get; set; }
        public int LockUntil { get; set; }
    }
}
