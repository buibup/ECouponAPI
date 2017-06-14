using ECouponAPI.Models;
using ECouponAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECouponAPI.Repository
{
    interface IECouponRepository
    {
        bool IsMember(string userName);
        List<CouponViewModels> GetCoupons(string memberId);
    }
}
