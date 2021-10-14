using System;
using System.Colections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechFabricSln
{ 
public class Bought
{
	public User MadeBy { get; get; }
	
	public bool IsBoughBy(User user)
	{
			if (user.customer)
				return true;
			if (MadeBy == user)
				return true;

			return false;
	}

}
public class User
{
	public bool customer { get; get; }
}
}