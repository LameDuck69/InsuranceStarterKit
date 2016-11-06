
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class PolicyAmendmentRepo: RepositoryBase<PolicyAmendment>
	{
		public PolicyAmendmentRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

