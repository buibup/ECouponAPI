using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ECouponAPI.ViewModels;
using ECouponAPI.Models;

namespace ECouponAPI.Repository
{
    public class ECouponRepository : IECouponRepository
    {
        EcouponBMCEntities _context;
        public ECouponRepository()
        {
            _context = new EcouponBMCEntities();
        }
        public List<CouponViewModels> GetCoupons(string memberId)
        {
            throw new NotImplementedException();
        }

        public bool IsMember(string userName)
        {
            throw new NotImplementedException();
        }
    }
}