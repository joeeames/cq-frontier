using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CQ.Frontier.Web.Models;

namespace CQ.Frontier.Web.Repo
{
	public class UserRepo
	{
		public Models.FrontiersEntities Entities;

		public System.Data.Objects.ObjectSet<Models.User> GetUsers()
		{
			Entities = new FrontiersEntities();
			return Entities.Users;
		}

	}
}