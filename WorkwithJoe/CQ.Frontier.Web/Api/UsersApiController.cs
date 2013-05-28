using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using CQ.Frontier.Web.Repo;

namespace CQ.Frontier.Web.Controllers
{
	public class UsersController : ApiController
	{
		// GET api/values
		public IEnumerable<Models.User> Get()
		{
			UserRepo UserRepo = new UserRepo();
			var users = UserRepo.GetUsers();
//			var strusers = from u in users select u.username;
			return users;
		}

		// GET api/values/5
		public string Get(int id)
		{
			return "value";
		}

		// POST api/values
		public void Post(string value)
		{
		}

		// PUT api/values/5
		public void Put(int id, string value)
		{
		}

		// DELETE api/values/5
		public void Delete(int id)
		{
		}
	}
}