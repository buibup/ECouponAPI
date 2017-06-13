using ECouponAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ECouponAPI.Controllers
{
    public class AccountController : ApiController
    {
        private IUser _Iuser;
        public AccountController()
        {
            _Iuser = new UserRepository();
        }

        [Authorize]
        public IHttpActionResult GetUserAccount(string user)
        {
            var model = _Iuser.GetUser(user);
            if(model == null)
            {
                return BadRequest();
            }

            return Ok(model);
        }
    }
}
