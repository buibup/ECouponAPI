using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECouponAPI.Models;

namespace ECouponAPI.Repository
{
    public interface IUser
    {
        USERACCOUNT GetUser(string user);
    }
}
