
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class PolicyTypeRepo: RepositoryBase<PolicyType>
	{
		public PolicyTypeRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

