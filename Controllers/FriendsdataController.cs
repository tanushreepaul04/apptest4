using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using friends_db_service.Models;

namespace friends_db_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendsdataController : Controller
    {
        private readonly FriendsdatadbContext db;

        public FriendsdataController(FriendsdatadbContext mydbContext)
        {
            db = mydbContext;
        }

        // GET: api/sampledb
        [HttpGet("SharedProducts")]
        public IEnumerable<object> GetSharedProducts(int userid)
        {
            try
            {
                List<object> datalist = new List<object>();

                var data = (from t in db.sharedproducts
                            join u in db.users on t.SharedByUserID equals u.UserID
                            where t.SharedToUserID == userid
                            select
                            new
                            {
                                t.ProductID,
                                t.Liked,
                                t.Rating,
                                u.UserName,
                                u.UserEmail,
                                u.UserImage
                            }
                            ).ToList<object>();

                if (data != null)
                    datalist = data;

                return datalist;
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }

        // GET: api/sampledb
        [HttpGet("Friends")]
        public IEnumerable<object> GetFriends(int userid)
        {
            try
            {
                List<object> datalist = new List<object>();

                var data = (from t in db.friends
                            join u in db.users on t.FriendUserID equals u.UserID
                            where t.UserID == userid
                            select
                            new
                            {
                                t.FriendUserID,
                                u.UserName,
                                u.UserEmail,
                                u.UserImage
                            }
                            ).ToList<object>();

                if (data != null)
                    datalist = data;

                return datalist;
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }

    }
}