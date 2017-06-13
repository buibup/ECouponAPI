using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ECouponAPI.Models;

namespace ECouponAPI.Repository
{
    public class UserRepository : IUser
    {
        EcouponBMCEntities _context;
        public UserRepository()
        {
            _context = new EcouponBMCEntities();
        }
        public USERACCOUNT GetUser(string user)
        {
            var data = (from d in _context.USERACCOUNTs
                        where d.USERNAME == user
                        select d).FirstOrDefault();

            if(data == null)
            {
                return new USERACCOUNT();
            }

            return data;
        }
    }
}