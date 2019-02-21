using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestAPI.Models;

namespace RestAPI.Controllers
{
    public class UserController : ApiController
    {
        // GET api/user
        public IEnumerable<UserInfo> Get()
        {
            var userInfoList = new List<UserInfo>();

            for(var i = 1; i <= 5; i++)
            {
                var userInfo = new UserInfo
                {
                    RegisteredUser = $"user #{i}",
                    DomainItems = "userInfo",
                    RegisteredDate = DateTime.Now,
                    ExpiredDate = DateTime.Now.AddMonths(12),
                    Description = $"user #{i} information"
                };
                userInfoList.Add(userInfo);
            }
            return userInfoList;
        }

        // GET api/user/1
        public UserInfo Get(int id)
        {
            return new UserInfo
            {
                RegisteredUser = $"user #{id}",
                DomainItems = "userInfo",
                RegisteredDate = DateTime.Now.ToUniversalTime(),
                ExpiredDate = DateTime.Now.ToUniversalTime().AddMonths(12),
                Description = $"user #{id} information"
            };
        }
    }
}
