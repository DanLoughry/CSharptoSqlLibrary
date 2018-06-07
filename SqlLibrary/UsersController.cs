using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlLibrary  {
	public class UsersController 	{

		public IEnumerable<User> List()	{   //creating a method called list with is an enumerable of list user
			return new List<User>();					// do not return null, instead return an empty list 
		}
		public User Get(int id) 	{		//these are stb methods that are defined but do not do anything alone
			return null;
		}
		public bool Create(User user)	{
			return false;
		}
		public bool Change(User user)		{
			return false;
		}
		public bool Remove(User user)	{
			return false;
		}
	}
}
