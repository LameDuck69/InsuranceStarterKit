
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class PasswordRepo: RepositoryBase<Password>
	{
		public PasswordRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

