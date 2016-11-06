
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class LoginRepo: RepositoryBase<Login>
	{
		public LoginRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

