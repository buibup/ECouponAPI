using ECouponAPI.Models;
using System.Collections.Generic;

namespace ECouponAPI.Repository
{
    interface IECouponRepository
    {
        bool IsMember(string userName);
        List<COUPON> GetCoupons(int memberId);
    }
}
