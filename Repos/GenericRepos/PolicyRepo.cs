
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class PolicyRepo: RepositoryBase<Policy>
	{
		public PolicyRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

