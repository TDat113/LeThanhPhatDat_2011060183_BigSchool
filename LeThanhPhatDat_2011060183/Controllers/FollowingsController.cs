using LeThanhPhatDat_2011060183.DTOs;
using LeThanhPhatDat_2011060183.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;


namespace LeThanhPhatDat_2011060183.Controllers
{
    public class FollowingsController : ApiController
    {
        // GET: Followings
       private readonly ApplicationDbContext _dbcontext;
        public FollowingsController()
        {
            _dbcontext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Follow(FollowingDto followingDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbcontext.Followings.Any(f => f.FollowerId == userId && f.FolloweeId == followingDto.FolloweeId))
                return BadRequest("Following already exists!");
            var folowing = new Following
            {
                FollowerId = userId,
                FolloweeId = followingDto.FolloweeId
            };
            _dbcontext.Followings.Add(folowing);
            _dbcontext.SaveChanges();
            return Ok();
        }
    }
}