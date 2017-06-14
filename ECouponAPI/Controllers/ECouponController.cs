using ECouponAPI.Models;
using ECouponAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ECouponAPI.Controllers
{
    [Authorize]
    public class ECouponController : ApiController
    {
        IECouponRepository _IECouponRepository;
        public ECouponController()
        {
            _IECouponRepository = new ECouponRepository();
        }

        [HttpGet]
        public bool IsMember(string userName)
        {
            return _IECouponRepository.IsMember(userName);
        }

        [HttpGet]
        public List<COUPON> GetCoupons(int memberId)
        {
            return _IECouponRepository.GetCoupons(memberId);
        }

        public IHttpActionResult GetUserFromToken()
        {
            var u = User;
            return Ok(u);
        }
    }
}
