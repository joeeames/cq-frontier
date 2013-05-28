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

        public void CreateUser(string username, string passwordhash)
        {
            Entities = new FrontiersEntities();
            User newUser = new User();
            newUser.username = username;
            newUser.salt = "1";
            newUser.passwordhash = passwordhash;

            Entities.Users.AddObject(newUser);
            Entities.SaveChanges();
            
        }

	}
}