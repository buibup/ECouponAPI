using System;
using System.Collections.Generic;
using ECouponAPI.Models;
using System.Linq;

namespace ECouponAPI.Repository
{
    public class ECouponRepository : IECouponRepository
    {
        EcouponBMCEntities _context;
        public ECouponRepository()
        {
            _context = new EcouponBMCEntities();
        }

        public List<COUPON> GetCoupons(int memberId)
        {
            var items = _context.COUPONs.Where(c => c.MEMBER_ID == memberId).ToList();

            if(items == null)
            {
                return new List<COUPON>();
            }

            return items;
        }

        public bool IsMember(string userName)
        {
            var isMem = _context.MEMBERs.Any(m => m.USERNAME == userName);

            return isMem;
        }
    }
}