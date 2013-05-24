using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CQ.Frontier.Web.Repo;
using NUnit.Framework;

namespace CQ.Frontier.Test.Model
{
	[TestFixture]
	public class EFTest1
	{
		[Test]
		public void TestSomething()
		{
			UserRepo UserRepo = new UserRepo();
			var users = UserRepo.GetUsers();
			Assert.AreEqual(users.Count(), 1);
		}
	}
}
